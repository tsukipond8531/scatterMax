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
            string strLambda = txtLambda.Text.ToString();
            string strVolume = txtVolume.Text.ToString();

            if (!isValidate(strLambda) || !isValidate(strVolume))
            {
                string message = "Please input valid values.";
                string caption = "Input Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
                return;
            }

            try
            {
                double dblLambda = Convert.ToDouble(strLambda);
                double dblVolume = Convert.ToDouble(strVolume);
                Complex m = new Complex(1, 1);

                Mie_abcd_result abcdResult = Mie_abcd.calc_mie_abcd(m, dblLambda, dblVolume);

                if (!abcdResult.isSuccess)
                {
                    MessageBox.Show(abcdResult.errStr, "Error", MessageBoxButtons.OK);
                    return;
                }

                labelResult.Text = abcdResult.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Format Error", MessageBoxButtons.OK);
                return;
            }

        }

        public bool isValidate(string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}
