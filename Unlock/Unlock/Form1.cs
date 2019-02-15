using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Unlock
{
    public partial class frmUnlock : Form
    {
        public frmUnlock()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           double dblCorrectCode = 0;
           double dblInputCode = 0;
           int I = 0;
           string tries = "";
           Double.TryParse(Interaction.InputBox("Please set the code", "Set Code", "****", 100, 100), out dblCorrectCode);

            do
            {
                double.TryParse(Interaction.InputBox("Please enter your code", "Enter Code", "****", 100, 100), out dblInputCode);
                if (dblInputCode == dblCorrectCode)
                {
                    MessageBox.Show("The code is correct! Welcome!");
                    I++;
                    if (I == 1)
                    {
                        tries = "try";
                    }
                    else
                    {
                        tries = "tries";
                    }
                    MessageBox.Show("It took you " + I + " " + tries);
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("The code is incorrect! Please try again!");
                    I++;
                }
            } while (dblInputCode != dblCorrectCode);
        }
    }
}
