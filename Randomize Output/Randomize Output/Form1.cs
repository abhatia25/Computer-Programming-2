using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomize_Output
{
    public partial class frmRndStr : Form
    {
        public frmRndStr()
        {
            InitializeComponent();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string month1 = "";
            Random rnd = new Random();
            int month = rnd.Next(1, 7);
            switch(month)
            {
                case 1:
                    month1 = "January";
                    break;
                case 2:
                    month1 = "February";
                    break;
                case 3:
                    month1 = "March";
                    break;
                case 4:
                    month1 = "April";
                    break;
                case 5:
                    month1 = "May";
                    break;
                case 6:
                    month1 = "June";
                    break;
                default:
                    month1 = "October";
                    break;
            }
            lblAnswer.Text = month1;
        }
    }
}