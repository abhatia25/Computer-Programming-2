using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] intArr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            String rowOfInts = "";
            String columnsAndRow = "";
            for (int r = 0; r < intArr.GetLength(0); r++)
            {
                String tempString = "";
                for (int c = 0; c < intArr.GetLength(1); c++)
                {
                    rowOfInts = tempString + " " + intArr[r, c];
                    tempString = rowOfInts;
                }
                columnsAndRow = columnsAndRow + rowOfInts + "\n";
                label1.Text = rowOfInts + columnsAndRow;
            }
        }
    }
}