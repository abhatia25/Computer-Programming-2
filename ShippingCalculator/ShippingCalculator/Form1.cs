using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum DeliveryTime { NxtDay = 80, SecondDay = 50, ThirdDay = 30, Ground = 0}
public enum Options { Rush = 30, Sat = 35, SigRequired = 1}
namespace ShippingCalculator
{
    public partial class frmShippingCalc : Form
    {
        public double Total = 6.79;
        public frmShippingCalc()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form About = new About();
            About.Show();
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rates are as follows: \nBase Rate: 6.79 \nEach pound over the base rate is .49 cents \nNext Day Air: Add $80, Second Day Air: Add $50, 3rd \nRush AM(only available with Next Day Air): Add $30 \nSaturday delivery: Add $35 \nInsurance: (Value of package / 100) * 1.56 \nFuel Surcharge: (shipRate * 0.0276) + 1.50");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Weight = 0;

            Weight ShippingCalc = new Weight();

            Double.TryParse(txtWeight.Text, out Weight);

            ShippingCalc.weight = Weight;
            ShippingCalc.Total();

            if (radNxtDay.Checked)
            {
                ShippingCalc.dblTotal += (int)DeliveryTime.NxtDay;
            }
            else if (rad2ndDay.Checked)
            {
                ShippingCalc.dblTotal += (int)DeliveryTime.SecondDay;
            }
            else if (rad3rdDay.Checked)
            {
                ShippingCalc.dblTotal += (int)DeliveryTime.ThirdDay;
            }
            else if (radGrd.Checked)
            {
                ShippingCalc.dblTotal += (int)DeliveryTime.Ground;
            }

            if(chkRush.Checked)
            {
                ShippingCalc.dblTotal += (int)Options.Rush;
            }
            if(chkSat.Checked)
            {
                ShippingCalc.dblTotal += (int)Options.Sat;
            }
            if(chkIns.Checked)
            {
                double value;
                Double.TryParse(txtVal.Text, out value);
                ShippingCalc.dblTotal += (value / 100) * 1.56; 
            }
            if(chkSig.Checked)
            {
                ShippingCalc.dblTotal += (int)Options.SigRequired;
                MessageBox.Show("Signature is Required!"); //shows message box is signature required
            }

            ShippingCalc.dblTotal += (ShippingCalc.dblTotal * 0.0276) + 1.5; //adds fuel cost

            MessageBox.Show("Total Cost: " + ShippingCalc.dblTotal.ToString("$##.00")); //shows final cost and formats for currency
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void chkSig_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radNxtDay_CheckedChanged(object sender, EventArgs e)
        {
            chkRush.Visible = true;
        }
    }
}