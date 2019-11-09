using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MieScatteringMax
{
    class Mie_pt
    {
        public static Mie_pt_result calc_mie_pt(double theta, int n_max)
        {
            #region The Function Mie_pt
            /*
             * { theta } -1 <= u = cos(theta) <= 1
             * { n_max } integer
             * 
             * { pi_n, tau_n } matrix
             * { n1 } integer from 1 to n_max
             */
            #endregion
            try
            {
                double[] p = new double[n_max];
                double[] t = new double[n_max];

                double p1, p2, t1, t2;

                p[0] = 1;
                t[0] = Math.Cos(theta);

                p[1] = 3 * Math.Cos(theta);
                t[1] = 3 * Math.Cos(2 * Math.Acos(Math.Cos(theta)));

                for (int n1 = 2; n1 < n_max; n1++)
                {
                    p1 = (2 * n1 - 1) / (n1 - 1) * Math.Cos(theta) * p[n1 - 1];
                    p2 = n1 / (n1 - 1) * p[n1 - 2];
                    p[n1] = p1 - p2;

                    t1 = n1 * Math.Cos(theta) * p[n1];
                    t2 = (n1 + 1) * p[n1 - 1];
                    t[n1] = t1 - t2;
                }

                return new Mie_pt_result()
                {
                    p = p,
                    t = t,
                    isSuccess = true
                };
            }
            catch (Exception error)
            {
                return new Mie_pt_result()
                {
                    errStr = error.Message,
                    isSuccess = false
                };
            }
        }
    }

    class Mie_pt_result
    {
        public double[] p { get; set; }
        public double[] t { get; set; }
        public string errStr { get; set; }
        public bool isSuccess { get; set; }
    }
}
