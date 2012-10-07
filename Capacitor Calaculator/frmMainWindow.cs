using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capacitor_Calaculator
{
    public partial class frmMainWindow : Form
    {
        float currentPF;
        float desiredPF;
        float powerKW;

        float kvr1;
        float v1;
        float f1;
        float mf1;

        float kvr2;
        float v2;
        float f2;
        float mf2;


        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender , EventArgs e)
        {
            try
            {
                //Calculating the best capacitor K.V.R
                //Inputs
                //Current Power factor 0->1
                //Apparent power in KW
                //Desired power factor 0->1
                //Result capcitor K.V.R
                //Equation : ApparentPower * Tan(Acos(CurrentPowerFactor))-Tan(Acos(desiredPowerFactor))
                tbCapacitorKVR.Text =Math.Round(( powerKW * (Math.Tan(Math.Acos(currentPF)) - Math.Tan(Math.Acos(desiredPF)))),3).ToString();
            }
            catch
            {
                MessageBox.Show("تأكد من القيم المدخلة");
            }
        }

        private void tbCurrentPF_TextChanged(object sender , EventArgs e)
        {
            try
            {
                currentPF = float.Parse(tbCurrentPF.Text);
            }
            catch
            {
                tbCurrentPF.Text = "";
            }
        }

        private void tbKw_TextChanged(object sender , EventArgs e)
        {
            try
            {
                powerKW = float.Parse(tbKw.Text);
            }
            catch
            {
                tbKw.Text = "";
            }
        }

        private void tbDesiredPF_TextChanged(object sender , EventArgs e)
        {
            try
            {
                desiredPF = float.Parse(tbDesiredPF.Text);
            }
            catch
            {
                tbDesiredPF.Text = "";
            }
        }

        private void btnKVR2MF_Click(object sender , EventArgs e)
        {
            tb1MF.Text =Math.Round( (((1000000000 * kvr1) / (v1 * v1 * 2 * Math.PI * f1)) * 100 / 100),3).ToString();
        }

      
        private void tb1MF_TextChanged(object sender , EventArgs e)
        {

        }

        private void tb1Volt_TextChanged(object sender , EventArgs e)
        {
            try
            {
                v1 = float.Parse(tb1Volt.Text);
            }
            catch
            {
                tb1Volt.Text = "";
            }
        }

        private void tb1Freq_TextChanged(object sender , EventArgs e)
        {
            try
            {
                f1 = float.Parse(tb1Freq.Text);
            }
            catch
            {
                tb1Freq.Text = "";
            }
        }

        private void tb1KVR_TextChanged(object sender , EventArgs e)
        {
            try
            {
                kvr1 = float.Parse(tb1KVR.Text);
            }
            catch
            {
                tb1KVR.Text = "";
            }
        }

        private void tb2MF_TextChanged(object sender , EventArgs e)
        {
            try
            {
                mf2 = float.Parse(tb2MF.Text);
            }
            catch
            {
                tb2MF.Text = "";
            }
        }

        private void tb2Volt_TextChanged(object sender , EventArgs e)
        {
            try
            {
                v2 = float.Parse(tb2Volt.Text);
            }
            catch
            {
                tb2Volt.Text = "";
            }
        }

        private void tb2Freq_TextChanged(object sender , EventArgs e)
        {
            try
            {
                f2 = float.Parse(tb2Freq.Text);
            }
            catch
            {
                tb2Freq.Text = "";
            }
        }

        private void btnMF2KVR_Click(object sender , EventArgs e)
        {
            tb2KVR.Text = Math.Round((((v2 * v2 * 2 * Math.PI * f2 * mf2) / 1000000000) * 100 / 100),3).ToString();
        }
    }
}
