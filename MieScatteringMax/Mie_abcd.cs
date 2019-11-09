//using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

namespace MieScatteringMax
{
    class Mie_abcd
    {
        public static Mie_abcd_result calc_mie_abcd(Complex m, double k0, double a)
        {
            #region The Function Mie_abcd
            /*
             * { m } complex refractive index, m = m' + im"
             * { k0 } wave number in the ambient medium
             * { a } sphere radius
             * 
             * size parameter, x = k0 * a
             */
            #endregion
            try
            {
                double x = k0 * a;
                // nmax = round(2+x+4*x^(1/3));
                int n_max = Convert.ToInt32(Math.Round(2 + x + 4 * Math.Pow(x, 1 / 3)));

                // n = (1:nmax);
                int[] n = Enumerable.Range(1, n_max).ToArray();
                // nu = (n+0.5);
                double[] nu = n.Select(e => Convert.ToDouble(e) + 0.5).ToArray(); // ?

                // z = m.*x;
                Complex z = Complex.Multiply(m, x);
                // m2 = m.*m;
                Complex m2 = Complex.Multiply(m, m);

                // sqx = sqrt(0.5*pi./x);
                double sqx = Math.Sqrt(0.5 * Math.PI / x);
                // sqz = sqrt(0.5*pi./z);
                Complex sqz = Complex.Sqrt(Complex.Divide(0.5 * Math.PI, z));

                // bx = besselj(nu, x).*sqx; ==>> n or nu?
                Complex[] bx = nu.Select(e => Complex.Multiply(SpecialFunctions.BesselJ(e, x), sqx)).ToArray();
                // bz = besselj(nu, z).*sqz;
                Complex[] bz = nu.Select(e => Complex.Multiply(SpecialFunctions.BesselJ(e, z), sqz)).ToArray();
                // yx = bessely(nu, x).*sqx;
                Complex[] yx = nu.Select(e => Complex.Multiply(SpecialFunctions.BesselY(e, x), sqx)).ToArray();
                // hx = bx+i*yx;
                Complex[] hx = bx.Select((e, index) => Complex.Add(e, Complex.Multiply(new Complex(0, 1), yx[index]))).ToArray();

                // b1x = [sin(x)/x, bx(1:nmax-1)];
                Complex[] b1x = bx.Select((e, index) => index == 0 ? Math.Sin(x) / x : bx[index - 1]).ToArray();
                // b1z = [sin(z)/z, bz(1:nmax-1)];
                Complex[] b1z = bz.Select((e, index) => index == 0 ? Complex.Divide(Complex.Sin(z), z) : bz[index - 1]).ToArray();
                // y1x = [-cos(x)/x, yx(1:nmax-1)];
                Complex[] y1x = yx.Select((e, index) => index == 0 ? -Math.Cos(x) / x : yx[index - 1]).ToArray();

                // h1x = b1x+i*y1x;
                Complex[] h1x = b1x.Select((e, index) => Complex.Add(e, Complex.Multiply(new Complex(0, 1), y1x[index]))).ToArray();
                // ax = x.*b1x-n.*bx;
                Complex[] ax = b1x.Select((e, index) => Complex.Subtract(Complex.Multiply(x, e), Complex.Multiply(n[index], bx[index]))).ToArray();
                // az = z.*b1z-n.*bz;
                Complex[] az = b1z.Select((e, index) => Complex.Subtract(Complex.Multiply(z, e), Complex.Multiply(n[index], bz[index]))).ToArray();
                // ahx = x.*h1x-n.*hx;
                Complex[] ahx = h1x.Select((e, index) => Complex.Subtract(Complex.Multiply(x, e), Complex.Multiply(n[index], hx[index]))).ToArray();

                // an = (m2.*bz.*ax-bx.*az)./(m2.*bz.*ahx-hx.*az);
                Complex[] an = bz.Select((e, index) => Complex.Divide(
                    Complex.Subtract(
                        Complex.Multiply(m2, Complex.Multiply(e, ax[index])),
                        Complex.Multiply(bx[index], az[index])
                    ),
                    Complex.Subtract(
                        Complex.Multiply(m2, Complex.Multiply(e, ahx[index])),
                        Complex.Multiply(hx[index], az[index])
                    )
                )).ToArray();
                // bn = (bz.*ax-bx.*az)./(bz.*ahx-hx.*az);
                Complex[] bn = bz.Select((e, index) => Complex.Divide(
                    Complex.Subtract(
                        Complex.Multiply(e, ax[index]),
                        Complex.Multiply(bx[index], az[index])
                    ),
                    Complex.Subtract(
                        Complex.Multiply(e, ahx[index]),
                        Complex.Multiply(hx[index], az[index])
                    )
                )).ToArray();
                // cn = (bx.*ahx-hx.*ax)./(bz.*ahx-hx.*az);
                Complex[] cn = ahx.Select((e, index) => Complex.Divide(
                    Complex.Subtract(
                        Complex.Multiply(bx[index], e),
                        Complex.Multiply(hx[index], ax[index])
                    ),
                    Complex.Subtract(
                        Complex.Multiply(bz[index], e),
                        Complex.Multiply(hx[index], az[index])
                    )
                )).ToArray();
                // dn = m.*(bx.*ahx-hx.*ax)./(m2.*bz.*ahx-hx.*az);
                Complex[] dn = ahx.Select((e, index) => Complex.Divide(
                    Complex.Multiply(
                        m,
                        Complex.Subtract(
                            Complex.Multiply(bx[index], e),
                            Complex.Multiply(hx[index], ax[index])
                        )
                    ),
                    Complex.Subtract(
                        Complex.Multiply(
                            m2,
                            Complex.Multiply(bz[index], e)
                        ),
                        Complex.Multiply(hx[index], az[index])
                    )
                )).ToArray();

                return new Mie_abcd_result()
                {
                    an = an,
                    bn = bn,
                    cn = cn,
                    dn = dn,
                    isSuccess = true
                };
            }
            catch (Exception error)
            {
                return new Mie_abcd_result()
                {
                    errStr = error.Message,
                    isSuccess = false
                };
            }
        }
    }

    class Mie_abcd_result
    {
        public Complex[] an { get; set; }
        public Complex[] bn { get; set; }
        public Complex[] cn { get; set; }
        public Complex[] dn { get; set; }
        public string errStr { get; set; }
        public bool isSuccess { get; set; }
    }
}
