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

namespace File_IO_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string srcPath = @"E:\Computer Programming 2\Test\";
        public static string destPath = @"E:\Computer Programming 2\Data\";
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Copy an existing file to another folder   
            //  ... assumes you have the file with rights to read it  My Documents - DATA folder and a TEST folder
            //  ... assumes you have write permission to the new location
            string fname = "data01.txt";  //supplied data files will use this naming convention throughout the course materials (editable with NotePad, no formatting)
                                          // let's check to see if the file exists in the DATA and TEST folders
            if (!File.Exists(srcPath + fname))
            {
                MessageBox.Show("Fire, Fire, Fire in the Deep Fat Fryer, FILE: " + srcPath + fname + " does not exist. Create it before continuing!");
                return;
            }
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("Ok, FILE: " + destPath + fname + " does not exist. I will Copy it for you!");
                File.Copy(srcPath + fname, destPath + fname);
            }
            // as long as you had a file in your DATA folder of this name, there is now a copy of it in your TEST folder.
            else
                MessageBox.Show("File: " + destPath + fname + " already exists, unlike MicroSoft, I will not create a 2nd copy");

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Delete an existing file   
            //  ... assumes you have the file somewhere with rights to read it  My Documents - DATA folder and a TEST folder
            //  ... assumes you have write permission to the new location
            string fname = "data01.txt";  //supplied data files will use this naming convention throughout the course materials                          		(editable with NotePad, no formatting)
            // let's check to see if the file exists in the DATA and TEST folders
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("No need to delete as " + srcPath + fname + " does not exist. Copy it before deleting!"); return;
            }

            if (File.Exists(destPath + fname))
            {
                MessageBox.Show("Ok, FILE: " + destPath + fname + " does exist and I will delete it for you!");
                File.Delete(destPath + fname);
            }
            // as long as you had a file in your DATA folder of this name, there is now a copy of it in your TEST folder.
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create a file   data03.txt
            //  ... assumes you have write permission to the new location
            string fname = "data01.txt";

            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("File: " + destPath + fname + " does not already exist, so I will create it");

                File.Create(destPath + fname);   // this creates the file with full 	access for the creator (user of this program)
                                                 // Inspect this file via Explorer and details, it’s size is 0  (empty)

            }
        }

        private void btnGetCreateTime_Click(object sender, EventArgs e)
        {
            string fname = "data01.txt";
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("File: " + destPath + fname + " does not exist. Create it before getting creation time!");
            }

            if (File.Exists(destPath + fname))
            {
                MessageBox.Show("File does exist and was created at: " + File.GetCreationTime(destPath + fname));
            }
        }

        private void btnGetAccessTime_Click(object sender, EventArgs e)
        {
            string fname = "data01.txt";
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("File: " + destPath + fname + " does not exist. Create it before getting last access time!");
            }

            if (File.Exists(destPath + fname))
            {
                MessageBox.Show("File does exist and was last accessed at: " + File.GetLastAccessTime(destPath + fname));
            }
        }

        private void btnGetWriteTime_Click(object sender, EventArgs e)
        {
            string fname = "data01.txt";
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("File: " + destPath + fname + " does not exist. Create it before getting last write time!");
            }

            if (File.Exists(destPath + fname))
            {
                MessageBox.Show("File does exist and was last written at: " + File.GetLastWriteTime(destPath + fname));
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string fname = "data01.txt";
            int i = 0;
            if (!File.Exists(destPath + fname))
            {
                MessageBox.Show("File: " + destPath + fname + " does not exist. Create it before moving!");
            }

            if (File.Exists(destPath + fname))
            {
                MessageBox.Show("Ok, FILE: " + destPath + fname + " does exist and I will move it for you!");
                File.Move(destPath + fname, srcPath + fname + i);
                i++;
            }
        }
    }
}