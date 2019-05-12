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

namespace IO_fileInfo_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            string srcFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DATA\\";
            FileInfo fil = new FileInfo(srcFolder + "data01.txt");
            LB.Items.Add("File Name:        " + fil.Name);
            LB.Items.Add("File Extension:    " + fil.Extension);
            LB.Items.Add("Full Name:        " + fil.FullName);
            LB.Items.Add("Parent Dir:       " + fil.DirectoryName);
            LB.Items.Add("File Size:        " + fil.Length.ToString() + " bytes");
            LB.Items.Add("Attributes:       " + fil.Attributes.ToString());
        }
    }
}
