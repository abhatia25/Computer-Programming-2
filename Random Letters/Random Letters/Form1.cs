using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Letters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random randLetter = new Random(); //static variable

        public static char GetLetter() //method that returns a value of type char
        {

            int Num1 = randLetter.Next(0, 26);
            char letter = (char)('a' + Num1);
            return letter;
        }

        public static char GetLetterUpper() //method that returns a value of type char
        {

            int Num1 = randLetter.Next(0, 26);
            char letter = (char)('A' + Num1);
            return letter;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            char randLetter1 = 'o';

            if (radUpper.Checked)
            {
                randLetter1 = GetLetterUpper();
            }
            else
            {
                randLetter1 = GetLetter();
            }

            MessageBox.Show(randLetter1.ToString());
        }
    }
}