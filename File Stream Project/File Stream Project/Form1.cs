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

namespace File_Stream_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Read method
        {
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
"\\DATA\\data03.txt";
            label1.Text = "Editing: " + fName;
            FileStream fs = new FileStream(fName, FileMode.Open, FileAccess.Read, FileShare.None); //gets the file in read only access mode
            //addthe using System.IO;referenceinNameSpace
            byte[] bText = new byte[fs.Length];//arrayofbytes, size of file //used to store contents of file
            fs.Read(bText, 0, bText.Length); //read file contents and store in array of bytes
            TB.Text = System.Text.Encoding.ASCII.GetString(bText); //wow .. convert byte array to string for Text property, BTW TB is theTextBox
            fs.Close(); //close file stream so others may use the file
        }

        private void button2_Click(object sender, EventArgs e) //Write method
        {
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
"\\TEST\\data03.txt";
            label1.Text = "Saved to: " + fName;
            FileStream fs = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);//opens, creates if nonexistent //write access mode
byte[] bText = System.Text.Encoding.ASCII.GetBytes(TB.Text);//wow .. convert Text property contents to bytearray – cool method/ concept
fs.Write(bText, 0, bText.Length); //write byte array to file from beginning to end
            fs.Close();//close file stream so others may use the file
        }
    }
}
