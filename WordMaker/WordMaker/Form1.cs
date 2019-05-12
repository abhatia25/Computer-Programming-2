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

namespace WordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            ArrayList arraylist = new ArrayList();
            string strInput = "";
            strInput = txtPhrase.Text;
            
            for (int i = 0; i < strInput.Length; i++)
            {
                arraylist.Add(strInput[i]);
            }

            foreach (char charString in arraylist)
            {
                lbxOutput.Items.Add(charString.ToString());
            }
            

        }
    }
}