using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MieScatteringMax
{
    class Mie_si12
    {
        public static Mie_si12_result calc_mie_si12(Complex m, double k0, double r, double theta)
        {
            #region The Function Mie_si12
            /*
             * Scattering Amplitude/Intensity, si1 & si2
             * 
             * { m } complex refractive index, m = m' + im"
             * { k0 } vacuum wave number
             * { r } sphere radius
             * { theta } scattering angle
             * 
             * size parameter, x = k0 * r
             * u = cos(theta)
             */
            #endregion
            try
            {
                double x = k0 * r;
                // nmax = round(2 + x + 4 * x ^ (1 / 3));
                int n_max = Convert.ToInt32(Math.Round(2 + x + 4 * Math.Pow(x, 1 / 3)));

                Mie_abcd_result abcd = Mie_abcd.calc_mie_abcd(m, k0, r);
                Complex[] an = abcd.an;
                Complex[] bn = abcd.bn;

                Mie_pt_result pt = Mie_pt.calc_mie_pt(theta, n_max);
                double[] pin = pt.p;
                double[] tin = pt.t;

                Complex si1 = new Complex(0, 0);
                Complex si2 = new Complex(0, 0);
                Complex si1_tmp = new Complex(0, 0);
                Complex si2_tmp = new Complex(0, 0);
                double n2;
                int n = 0;
                for (n = 0; n < n_max; n++)
                {
                    n2 = (2 * (n + 1) + 1) / ((n + 1) * ((n + 1) + 1));

                    si1_tmp = Complex.Multiply(
                        n2,
                        Complex.Add(Complex.Multiply(an[n], pin[n]), Complex.Multiply(bn[n], tin[n]))
                    );
                    si1 = Complex.Add(si1, si1_tmp);

                    si2_tmp = Complex.Multiply(
                        n2,
                        Complex.Add(Complex.Multiply(an[n], tin[n]), Complex.Multiply(bn[n], pin[n]))
                    );
                    si2 = Complex.Add(si2, si2_tmp);
                }

                return new Mie_si12_result()
                {
                    si1 = si1,
                    si2 = si2,
                    an = an,
                    bn = bn,
                    n_max = n_max,
                    isSuccess = true
                };
            }
            catch (Exception error)
            {
                return new Mie_si12_result()
                {
                    errStr = error.Message,
                    isSuccess = false
                };
            }
        }
    }

    class Mie_si12_result
    {
        public Complex si1 { get; set; }
        public Complex si2 { get; set; }
        public Complex[] an { get; set; }
        public Complex[] bn { get; set; }
        public int n_max { get; set; }
        public string errStr { get; set; }
        public bool isSuccess { get; set; }
    }
}
