using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MieScatteringMax
{
    class Mie_s12
    {
        public static Mie_s12_result calc_mie_s12(Complex m, double k0, double a, double theta)
        {
            #region The Function Mie_s12
            /*
             * Scattering amplitudes S1 and S2
             * 
             * { m } complex refractive index, m = m' + im"
             * { k0 } vacuum wave number
             * { a } sphere radius
             * { theta } scattering angle
             * 
             * size parameter, x = k0 * a
             * u = cos(theta)
             */
            #endregion
            try
            {
                double x = k0 * a;
                // nmax = round(2+x+4*x^(1/3));
                int n_max = Convert.ToInt32(Math.Round(2 + x + 4 * Math.Pow(x, 1 / 3)));

                Mie_abcd_result abcd = Mie_abcd.calc_mie_abcd(m, k0, a);
                Complex[] an = abcd.an;
                Complex[] bn = abcd.bn;

                Mie_pt_result pt = Mie_pt.calc_mie_pt(theta, n_max);
                double[] pin = pt.p;
                double[] tin = pt.t;

                Complex s1 = new Complex(0, 0);
                Complex s2 = new Complex(0, 0);
                Complex s1_tmp = new Complex(0, 0);
                Complex s2_tmp = new Complex(0, 0);
                double n2;
                int n = 0;
                for (n = 0; n < n_max; n++)
                {
                    n2 = (2 * (n + 1) + 1) / ((n + 1) * ((n + 1) + 1));

                    s1_tmp = Complex.Multiply(
                        n2,
                        Complex.Add(Complex.Multiply(an[n], pin[n]), Complex.Multiply(bn[n], tin[n]))
                    );
                    s1 = Complex.Add(s1, s1_tmp);

                    s2_tmp = Complex.Multiply(
                        n2,
                        Complex.Add(Complex.Multiply(an[n], tin[n]), Complex.Multiply(bn[n], pin[n]))
                    );
                    s2 = Complex.Add(s2, s2_tmp);
                }

                return new Mie_s12_result()
                {
                    s1 = s1,
                    s2 = s2,
                    an = an,
                    bn = bn,
                    n_max = n_max,
                    isSuccess = true
                };
            }
            catch (Exception error)
            {
                return new Mie_s12_result()
                {
                    errStr = error.Message,
                    isSuccess = false
                };
            }
        }
    }

    class Mie_s12_result
    {
        public Complex s1 { get; set; }
        public Complex s2 { get; set; }
        public Complex[] an { get; set; }
        public Complex[] bn { get; set; }
        public int n_max { get; set; }
        public string errStr { get; set; }
        public bool isSuccess { get; set; }
    }
}
