using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        public static string strWord = "";
        public static int intIncorrectGuesses = 0;
        public static int length = 0;
        public Char[] WordArray;
        public String[] AnswerArray;
        public static int GoodLetters = 0;
        public static int BadLetters = 0;


        public frmHangman()
        {
            InitializeComponent();
        }

        public void btnAssign_Click(object sender, EventArgs e)
        {
            strWord = txtWord.Text;
            length = strWord.Length;
            txtWord.Text = "";

            CreateArray();

            for (int i = 0; i < length; i++)
            {
                WordArray[i] = strWord[i];
            }

            AnswerArray = new string[length];

            for (int i = 0; i < AnswerArray.Length; i++)
            {
                AnswerArray[i] = "_";
            }

            DisplayArray();
        }

        public void DisplayArray()
        {
            for (int i = 0; i < AnswerArray.Length; i++)
            {
                lblAnswer.Text += " " + AnswerArray[i] + " ";
            }
            lblBad.Text = intIncorrectGuesses.ToString();
        }
        public void CreateArray()
        {
            WordArray = new char[length];
        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            char Test;
            Char charLetter;
            if (Char.TryParse(txtLetter.Text, out charLetter))
            {
                for(int counter = 0; counter < WordArray.Length; counter++)
                {
                    if (GoodLetters == length)
                    {
                        MessageBox.Show("You Win!");
                    }
                    else if (BadLetters == length) //does not work currently
                    {
                        intIncorrectGuesses += 1;
                    }
                    else
                    {
                        if (WordArray[counter] == charLetter)
                        {
                            AnswerArray[counter] = charLetter.ToString();
                            GoodLetters += 1;
                        }
                        else
                        {
                            if (Char.TryParse(AnswerArray[counter], out Test)) //should be changed to search
                            {
                                BadLetters += 1;
                            }
                            else
                            {
                                AnswerArray[counter] = "_";
                                BadLetters += 1;
                            }
                        }
                    }
                    
                }

                if (intIncorrectGuesses == 0)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources.start;
                }
                else if (intIncorrectGuesses == 1)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._2;
                }
                else if (intIncorrectGuesses == 2)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._3;
                }
                else if (intIncorrectGuesses == 3)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._4;
                }
                else if (intIncorrectGuesses == 4)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._5;
                }
                else if (intIncorrectGuesses == 5)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._6;
                }
                else if (intIncorrectGuesses == 6)
                {
                    picHangman.BackgroundImage = Hangman.Properties.Resources._7;
                    MessageBox.Show("You Lose!");
                }
                DisplayArray();

            }
            else
            {
                MessageBox.Show("Please enter only one character");
            }
        }
    }
}