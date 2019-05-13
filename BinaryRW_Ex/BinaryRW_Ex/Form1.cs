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

namespace BinaryRW_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string n;
        public static int g;
        public static int ctr;
        public static Single gpa;

        private void button3_Click(object sender, EventArgs e)
        {
            ctr++;
            switch (ctr)
            {
                case 1:
                    n = TB.Text; TB.Text = "";
                    MessageBox.Show("Good to meet you, " + n + ", I am Hal");
                    label1.Text = "What is your grade? (9,10,11,12)";
                    break;
                case 2:
                    g = Convert.ToInt32(TB.Text); TB.Text = "";
                    MessageBox.Show("Hmmm, a " + g.ToString() + "thgrader!");
                    label1.Text = "What is your GPA to 2 decimals?";
                    break;
                case 3:
                    gpa = Convert.ToSingle(TB.Text); TB.Text = "";
                    label1.Text = "";
                    MessageBox.Show(gpa > 3.0 ? "That's pretty good." : "Hopefully it will improve after this course.");
                    ctr = 0;
                    btnGo.Visible = false;
                    btnSave.Enabled = true;
                    break;
        }
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
"\\DATA\\data04.txt";
            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None); // here's our FileStream
            BinaryWriter w = new BinaryWriter(fs);
            //constructBianryWriterwith theFileStream, and then write our data to file
            w.Write("NickName is: " + n + "\r\n");
            w.Write("Grade: "); w.Write(g);
            w.Write("\r\nGPA: "); w.Write(gpa);
            w.Close(); fs.Close(); btnRead.Enabled = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            TB.Text = ""; //just in case you have been doodling
            string fname = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DATA\\data04.txt";
            label1.Text = "Read File: " + fname;
            FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read, FileShare.None); // here's ourFileStream
            BinaryReader r = new BinaryReader(fs); // constructBianryReaderwith theFileStream, and then read our data from file
                                                 //note the reader reads the requested primitives with appropriate methods
            string name = r.ReadString(); //whole line since topic and data samedatatype(: is handy for stripping it off if needed)
            string gradstr = r.ReadString(); //just the string topic phrase
            int grade = r.ReadInt32(); //ahhthe actual number as an integer
            string gpastr = r.ReadString(); // thegpatopic phrase
            double gradeAvg = r.ReadDouble(); // and finally thegpa
                                             //concatenate primitives into a string as desired for display into textbox
            string ss = gradeAvg > 4.0 ? "rocket scientist" : "student";
            TB.Text = name + " is a " + grade.ToString() + "thgrade " + ss;
            TB.Text += " with a GPA of " + gradeAvg.ToString(); r.Close(); fs.Close();
        }
    }
}
