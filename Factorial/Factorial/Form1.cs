using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double dblInput;
            Double.TryParse(txtInput.Text, out dblInput);
            int intI = 0;
            Double dblResult = 1;

            for (intI=0; intI<dblInput; intI++)
            {
                dblResult = dblResult * (dblInput - intI);
            }

            lblAnswer.Text = dblResult.ToString();
        }
    }
}
