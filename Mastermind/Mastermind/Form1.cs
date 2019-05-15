using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Mastermind
{
    public partial class frmMasterMind : Form
    {
        public static string name = "Hal";
        public static string strPin = "";
        public static int pinNumb1 = 0;
        public static int pinNumb2 = 0;
        public static int pinNumb3 = 0;
        public static int pinNumb4 = 0;
        public static int guess = 0;
        public static int rightOn = 0;
        public static int nearby = 0;
        public static int game = 1;
        public static int totalGuesses = 0;

        public frmMasterMind()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnTakeAShot_Click(object sender, EventArgs e)
        {
            guess ++;
            rightOn = 0;
            nearby = 0;
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Num4 = 0;
            string Pin = "";
            Int32.TryParse(cmbNumber1.Text, out Num1);
            Int32.TryParse(cmbNumber2.Text, out Num2);
            Int32.TryParse(cmbNumber3.Text, out Num3);
            Int32.TryParse(cmbNumber4.Text, out Num4);
            Pin = Num1.ToString() + Num2.ToString() + Num3.ToString() + Num4.ToString();

            if (Num1 == pinNumb1)
            {
                rightOn++; 
            }
            else if (Num1 == pinNumb2 || Num1 == pinNumb3 || Num1 == pinNumb4)
            {
                nearby++;
            }

            if (Num2 == pinNumb2)
            {
                rightOn++;
            }
            else if (Num2 == pinNumb1 || Num2 == pinNumb3 || Num2 == pinNumb4)
            {
                nearby++;
            }

            if (Num3 == pinNumb3)
            {
                rightOn++;
            }
            else if (Num3 == pinNumb2 || Num3 == pinNumb1 || Num3 == pinNumb4)
            {
                nearby++;
            }

            if (Num4 == pinNumb4)
            {
                rightOn++;
            }
            else if (Num4 == pinNumb2 || Num4 == pinNumb3 || Num4 == pinNumb1)
            {
                nearby++;
            }

            lblGuess.Text = guess.ToString();
            lblNearby.Text = nearby.ToString();
            lblRightOn.Text = rightOn.ToString();

            lbxOutput.Items.Add(Pin + " " + nearby.ToString() + " " + rightOn.ToString());

            ResetTrials();

            if (rightOn == 4)
            {
                MessageBox.Show("You win! Go to options, new to start a new game.");
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a 4-digit number." +
                "\nTwo clues are provided." +
                "\nRightOns is the # of exact matches." +
                "\nNearbys is the # of guessed digits contained in secret # but not in exact location");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aditya Bhatia\nComputer Programming 2\n5/24/2019");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game++;
            name = "Hal";
            guess = 0;
            rightOn = 0;
            nearby = 0;
            lbxOutput.Items.Clear();
            pinNumb1 = 0;
            pinNumb2 = 0;
            pinNumb3 = 0;
            pinNumb4 = 0;
            strPin = "";
            ResetTrials();
            MessageBox.Show("Hello Player 1 aka(" + name + "), I hope you are well today.");
            lbxOutput.Items.Add("Game " + game.ToString());
            Random rnd = new Random();
            pinNumb1 = rnd.Next(10);
            pinNumb2 = rnd.Next(10);
            pinNumb3 = rnd.Next(10);
            pinNumb4 = rnd.Next(10);
            strPin = pinNumb1.ToString() + pinNumb2.ToString() + pinNumb3.ToString() + pinNumb4.ToString();
            lblGuess.Text = guess.ToString();
            lblNearby.Text = nearby.ToString();
            lblRightOn.Text = rightOn.ToString();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int average = 0;
            string strAverage = "";
            try
            {
                average = totalGuesses / (game - 1);
                strAverage = average.ToString();
            }
            catch
            {
                strAverage = "NaN";
            }
            lbxOutput.Items.Add((game - 1).ToString() + " games. " + totalGuesses + " total guesses. " + strAverage + " average.");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                strPin = Microsoft.VisualBasic.Interaction.InputBox("4 Digit Number", "Set Code");
                strPin = strPin.Substring(0, 4);
                Int32.TryParse(Convert.ToString(strPin[0]), out pinNumb1);
                Int32.TryParse(Convert.ToString(strPin[1]), out pinNumb2);
                Int32.TryParse(Convert.ToString(strPin[2]), out pinNumb3);
                Int32.TryParse(Convert.ToString(strPin[3]), out pinNumb4);
            }
            catch
            {
                MessageBox.Show("Please make sure your pin is a 4 digit integer");
            }
        }

        private void peekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strPin);
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name = Microsoft.VisualBasic.Interaction.InputBox("Your handle if you please?", "Name/Hombre", name, 0, 0);
        }

        private void frmMasterMind_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void cmbNumber4_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumber4.Text = cmbNumber4.Text;
        }

        private void cmbNumber3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumber3.Text = cmbNumber3.Text;
        }

        private void cmbNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumber2.Text = cmbNumber2.Text;
        }

        private void cmbNumber1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumber1.Text = cmbNumber1.Text;
        }

        private void Reset()
        {
            name = "Hal";
            guess = 0;
            game = 1;
            rightOn = 0;
            nearby = 0;
            lbxOutput.Items.Clear();
            pinNumb1 = 0;
            pinNumb2 = 0;
            pinNumb3 = 0;
            pinNumb4 = 0;
            strPin = "";
            ResetTrials();
            MessageBox.Show("Hello Player 1 aka(" + name + "), I hope you are well today.");
            lbxOutput.Items.Add("Game " + game.ToString());
            Random rnd = new Random();
            pinNumb1 = rnd.Next(10);
            pinNumb2 = rnd.Next(10);
            pinNumb3 = rnd.Next(10);
            pinNumb4 = rnd.Next(10);
            strPin = pinNumb1.ToString() + pinNumb2.ToString() + pinNumb3.ToString() + pinNumb4.ToString();
            lblGuess.Text = guess.ToString();
            lblNearby.Text = nearby.ToString();
            lblRightOn.Text = rightOn.ToString();
        }

        private void ResetTrials()
        {
            cmbNumber1.Text = "";
            cmbNumber2.Text = "";
            cmbNumber3.Text = "";
            cmbNumber4.Text = "";
            lblNumber1.Text = "?";
            lblNumber2.Text = "?";
            lblNumber3.Text = "?";
            lblNumber4.Text = "?";
        }
    }
}
