using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MieScatteringMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string message, caption;
            MessageBoxButtons button;

            string str_n0 = txt_n0.Text.ToString();
            string str_alpha = txt_alpha.Text.ToString();
            string str_n_s = txt_n_s.Text.ToString();
            string str_HC_min = txt_HC_min.Text.ToString();
            string str_HC_max = txt_HC_max.Text.ToString();
            string str_M_mass = txt_M_mass.Text.ToString();
            string str_lambda = txt_lambda.Text.ToString();
            string str_eps = txt_eps.Text.ToString();

            string str_V_min = txt_V_min.Text.ToString();
            string str_V_max = txt_V_max.Text.ToString();

            string str_Theta_1 = txt_Theta_1.Text.ToString();
            string str_delta_Theta_1 = txt_delta_Theta_1.Text.ToString();
            string str_Theta_2 = txt_Theta_2.Text.ToString();
            string str_delta_Theta_2 = txt_delta_Theta_2.Text.ToString();

            string str_S1 = txt_S1.Text.ToString();
            string str_S2 = txt_S2.Text.ToString();

            // Validation of Parameters - Complex Refractive Index
            if (
                !isValidate(str_n0) || !isValidate(str_alpha) || !isValidate(str_n_s) ||
                !isValidate(str_HC_min) || !isValidate(str_HC_max) ||
                !isValidate(str_M_mass) || !isValidate(str_lambda) || !isValidate(str_eps)
            )
            {
                message = "Parameters of Complex Refractive Index are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            double HC_min = Convert.ToDouble(str_HC_min);
            double HC_max = Convert.ToDouble(str_HC_max);

            if (HC_min < 0 || HC_max < 0 || HC_max <= HC_min)
            {
                message = "HC values of Complex Refractive Index are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            // Validation of Parameters - Size Parameter
            if (!isValidate(str_V_min) || !isValidate(str_V_max))
            {
                message = "Size parameters are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            double V_min = Convert.ToDouble(str_V_min);
            double V_max = Convert.ToDouble(str_V_max);

            if (V_min < 0 || V_max < 0 || V_max <= V_min)
            {
                message = "V values of Size Parameter are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            // Validation of Parameters - Scattering Angle
            if (
                !isValidate(str_Theta_1) || !isValidate(str_delta_Theta_1) ||
                !isValidate(str_Theta_2) || !isValidate(str_delta_Theta_2)
            )
            {
                message = "Parameters of Scattering Angle are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            // Validation of Parameters - Estimation Arguments
            if (!isValidate(str_S1) || !isValidate(str_S2))
            {
                message = "Parameters of Estimation Arguments are incorrect." + Environment.NewLine + "Please input them correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            // main calc logic
            try
            {
                double n0 = Math.Abs(Convert.ToDouble(str_n0));
                double alpha = Math.Abs(Convert.ToDouble(str_alpha));
                double n_s = Math.Abs(Convert.ToDouble(str_n_s));
                double M_mass = Math.Abs(Convert.ToDouble(str_M_mass));
                double lambda = Math.Abs(Convert.ToDouble(str_lambda));
                double eps = Math.Abs(Convert.ToDouble(str_eps));

                double Theta_1 = Math.Abs(Convert.ToDouble(str_Theta_1));
                double delta_Theta_1 = Math.Abs(Convert.ToDouble(str_delta_Theta_1));
                double Theta_2 = Math.Abs(Convert.ToDouble(str_Theta_2));
                double delta_Theta_2 = Math.Abs(Convert.ToDouble(str_delta_Theta_2));

                double S1 = Math.Abs(Convert.ToDouble(str_S1));
                double S2 = Math.Abs(Convert.ToDouble(str_S2));

                double m1 = 0.0, m2 = 0.0;
                Complex m = new Complex(0, 0);
                double k0 = 0.0, r = 0.0;

                double _ln10 = Math.Log10(10);
                double _PI = Math.PI;
                
                DateTime start_outer, start_inner;
                TimeSpan diff;

                using (System.IO.StreamWriter file1 = new System.IO.StreamWriter(@".\MappingTableS1.txt", true))
                {
                    using (System.IO.StreamWriter file2 = new System.IO.StreamWriter(@".\MappingTableS2.txt", true))
                    {
                        for (double v = V_min; v <= V_max; v += 0.5)
                        {
                            for (double hc = HC_min; hc <= HC_max; hc += 0.5)
                            {
                                m1 = n0 + alpha * hc;
                                m2 = _ln10 / (_PI * M_mass) * lambda * eps * hc;
                                m = new Complex(m1, m2 * -1);

                                k0 = 2 * _PI / lambda;
                                r = Math.Pow(3 * v / (4 * _PI), 1 / 3);

                                Mie_si12_result si12_res;

                                double S1_tmp = 0.0, S2_tmp = 0.0;
                                double _step = 0.05;

                                start_outer = DateTime.Now;
                                System.Console.WriteLine("Integration of S1 begins...");

                                for (double theta1 = Theta_1; theta1 <= Theta_1 + delta_Theta_1; theta1 += _step)
                                {
                                    double theta1_rad = _PI / 90 * theta1;

                                    //start_inner = DateTime.Now;

                                    si12_res = Mie_si12.calc_mie_si12(m, k0, r, theta1_rad);
                                    if (!si12_res.isSuccess)
                                    {
                                        MessageBox.Show(si12_res.errStr, "Error", MessageBoxButtons.OK);
                                        goto BreakLoops;
                                    }

                                    //diff = DateTime.Now - start_inner;
                                    //System.Console.WriteLine("Mie_sil2 : {0} second(s)", diff.TotalSeconds);

                                    S1_tmp += (Math.Pow(Complex.Abs(si12_res.si1), 2) + Math.Pow(Complex.Abs(si12_res.si2), 2)) * Math.Sin(theta1_rad);
                                }
                                S1_tmp *= _PI / Math.Pow(2 * _PI * n_s / lambda, 2) * _step;

                                diff = DateTime.Now - start_outer;
                                System.Console.WriteLine("Integration of S1 ends in {0} second(s)", diff.TotalSeconds);

                                start_outer = DateTime.Now;
                                System.Console.WriteLine("Integration of S2 begins...");

                                for (double theta2 = Theta_2; theta2 <= Theta_2 + delta_Theta_2; theta2 += _step)
                                {
                                    double theta2_rad = _PI / 90 * theta2;

                                    //start_inner = DateTime.Now;

                                    si12_res = Mie_si12.calc_mie_si12(m, k0, r, theta2_rad);
                                    if (!si12_res.isSuccess)
                                    {
                                        MessageBox.Show(si12_res.errStr, "Error", MessageBoxButtons.OK);
                                        goto BreakLoops;
                                    }

                                    //diff = DateTime.Now - start_inner;
                                    //System.Console.WriteLine("Mie_sil2 : {0} second(s)", diff.TotalSeconds);

                                    S2_tmp += (Math.Pow(Complex.Abs(si12_res.si1), 2) + Math.Pow(Complex.Abs(si12_res.si2), 2)) * Math.Sin(theta2_rad);
                                }
                                S2_tmp *= _PI / Math.Pow(2 * _PI * n_s / lambda, 2) * _step;

                                diff = DateTime.Now - start_outer;
                                System.Console.WriteLine("Integration of S2 ends in {0} second(s)", diff.TotalSeconds);

                                file1.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", v.ToString("F4"), hc.ToString("F4"), Theta_1.ToString("F4"), delta_Theta_1.ToString("F4"), S1_tmp);
                                file2.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", v.ToString("F4"), hc.ToString("F4"), Theta_2.ToString("F4"), delta_Theta_2.ToString("F4"), S2_tmp);

                                // txt_V_res.Text = S1_tmp.ToString();
                                // txt_HC_res.Text = S2_tmp.ToString();
                            }
                        }
                    }
                }

            BreakLoops:
                return;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK);
                return;
            }

        }

        public bool isValidate(string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}
