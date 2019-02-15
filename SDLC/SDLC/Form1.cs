using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDLC
{
    public partial class frmSDLC : Form
    {
        public frmSDLC()
        {
            InitializeComponent();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Aditya Bhatia and Alexander Neiberger \nDate: 2 / 4 / 2019 \nVersion: 2.0");
        }
    }
}
