using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Remove_Unlucky_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        private void button1_Click(object sender, EventArgs e)
        {
            int intRemove = 0;
            int intLocation = 0;
            Int32.TryParse(txtReplace.Text, out intRemove);

            intLocation = list.BinarySearch(intRemove);
            list.RemoveAt(intLocation);

            lblList.Text = "End List: ";
            foreach (int i in list)
            {
                lblList.Text += i;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);

            lblList.Text = "Initial List: ";
            foreach (int i in list)
            {
                lblList.Text += i;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblList.Text = "Initial List: ";
            foreach(int i in list)
            {
                lblList.Text += i;
            }
        }
    }
}