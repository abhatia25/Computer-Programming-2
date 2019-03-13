using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball_Roster
{
    public partial class frmBasketballRoster : Form
    {
        public frmBasketballRoster()
        {
            InitializeComponent();
        }

        AddPlayer[] bballPlayer;
        int counter = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            counter = 0;
            try
            {
                int howMany = Convert.ToInt32(txtPlayers.Text);
                bballPlayer = new AddPlayer[howMany];
                for (int i = 0; i < howMany; i++)
                {
                    bballPlayer[i] = new AddPlayer();
                }
            }
            catch
            {
                MessageBox.Show("Enter a whole number only.");
            }
            txtRoster.Text = "Last Name First Name Height Position Year \r\n";
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                bballPlayer[counter].LastName = txtLastName.Text;
                bballPlayer[counter].FirstName = txtFirstName.Text;
                bballPlayer[counter].height = Convert.ToInt32(txtHeight.Text);
                bballPlayer[counter].position = Convert.ToInt32(txtPosition.Text);
                bballPlayer[counter].Year = txtYear.Text;

                txtRoster.Text += bballPlayer[counter].LastName + "                " + bballPlayer[counter].FirstName + "      " + bballPlayer[counter].height + "       " + bballPlayer[counter].position + "       " + bballPlayer[counter].Year + "\r\n";
                counter++;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter either FR, SO, JR, or SR for the Year"); 
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("You already entered the max number of players");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a number for height or postion!");
            }
        }
    }
}