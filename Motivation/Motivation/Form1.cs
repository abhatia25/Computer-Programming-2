using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motivation
{
    public partial class frmMotivation : Form
    {
        public frmMotivation()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int intTimes;
            int i = 0;
            Int32.TryParse(txtInput.Text, out intTimes);
            string strOutput = "";


            while (1 <= intTimes & intTimes <= 10)
            {
                for (i = 0; i <= intTimes-1; i++)
                {
                    strOutput += "Study!\n";
                }
                intTimes = 11;
            }

            lblOutput.Text = strOutput;
        }
    }
}
