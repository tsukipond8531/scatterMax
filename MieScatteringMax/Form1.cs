using Newtonsoft.Json;
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strM1 = txtM1.Text.ToString();
            string strM2 = txtM2.Text.ToString();
            string strK0 = txtK0.Text.ToString();
            string strA = txtA.Text.ToString();
            string strTheta = txtTheta.Text.ToString();

            string message, caption;
            MessageBoxButtons button;

            if (!isValidate(strM1) || !isValidate(strM2))
            {
                message = "Please input Complex Refractive Index correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }
            if (!isValidate(strK0) || !isValidate(strA))
            {
                message = "Please input Size Parameter correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }
            if (!isValidate(strTheta))
            {
                message = "Please input Scattering Angle correctly.";
                caption = "Input Error";
                button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            try
            {
                double m1 = Convert.ToDouble(strM1);
                double m2 = Convert.ToDouble(strM2);
                Complex m = new Complex(m1, m2);

                double k0 = Convert.ToDouble(strK0);
                double a = Convert.ToDouble(strA);
                double x = k0 * a;

                double thetaRad = Math.PI / 90 * Convert.ToDouble(strTheta);

                Mie_s12_result s12Result = Mie_s12.calc_mie_s12(m, k0, a, thetaRad);
                
                if (!s12Result.isSuccess)
                {
                    MessageBox.Show(s12Result.errStr, "Error", MessageBoxButtons.OK);
                    return;
                }

                txtRes_Nmax.Text = s12Result.n_max.ToString();
                richTxt_An.Text = myConvertArr2Str(s12Result.an);
                richTxt_Bn.Text = myConvertArr2Str(s12Result.bn);

                txtRes_S1.Text = s12Result.s1.ToString();
                txtRes_S2.Text = s12Result.s2.ToString();

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

        public string myConvertArr2Str(Complex[] arr)
        {
            string strResult = "";
            int index = 0;
            foreach(Complex element in arr)
            {
                index++;
                strResult += "[ " + index + " ]\n(" + element.Real + ", " + element.Imaginary + ")\n\n";
            }
            return strResult;
        }
    }
}
