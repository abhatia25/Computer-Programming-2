using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerOf2
{
    public partial class frmPowerOf2 : Form
    {
        public frmPowerOf2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblExpon = 0;
            double dblExpo = 0;
            int intExpo = 0;
            int intExpon = 0;
            for (dblExpon = 1; dblExpon < 10; dblExpon++)
            {
                dblExpo = Math.Pow(2, dblExpon);
                lblAnswer.Text += "2 to the " + intExpon.ToString() + " power equals " + intExpo.ToString() + "." + "\n";
            }
        }
    }
}
