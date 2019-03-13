using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[5];

            int i = 0;
            for (i = 0; i < 5; i++)
            {
                students[i] = new Student();
            }

            try
            {
                int counter = 0; //array index counter
                students[counter].Name = txtName.Text;
                students[counter].GPA = Convert.ToDouble(txtGPA.Text);
                txtOutput.Text += "Name: " + students[counter].Name + "\r\n GPA: " + students[counter].GPA.ToString() + "\r\n";
                counter++; //increment the array index counter by 1
                txtName.Text = string.Empty;
                txtGPA.Text = string.Empty;
                txtName.Focus();
            }

            catch (ArgumentException) //GPA is out of range
            {
                MessageBox.Show("Please enter a proper GPA");
            }
            catch (IndexOutOfRangeException) //array is full
            {
                MessageBox.Show("There are already 5 students.");
            }
        }
    }
}
