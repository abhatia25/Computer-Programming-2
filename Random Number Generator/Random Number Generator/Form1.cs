using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            int intnum1 = 0;

            Random RandomnumGen = new Random();

            intnum1 = RandomnumGen.Next(0, 15);

            MessageBox.Show(intnum1.ToString());
        }
    }
}
