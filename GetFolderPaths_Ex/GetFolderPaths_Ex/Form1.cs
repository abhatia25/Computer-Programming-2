using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFolderPaths_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LB.Items.Add("Curr Dir:\t\t" + Environment.CurrentDirectory);
            LB.Items.Add("......... a few system level folders........");
            LB.Items.Add("Windows System:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.System));
            LB.Items.Add("Program Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            LB.Items.Add("Common Program Files:\t" + Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
            LB.Items.Add("......... a few user specific folders.......");
            LB.Items.Add("Win Desktop:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            LB.Items.Add("Start Menu:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
            LB.Items.Add("History:\t\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.History));
            LB.Items.Add("Favorites:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
            LB.Items.Add("My Documents (Personal)\t" + Environment.GetFolderPath(Environment.SpecialFolder.Personal));

        }
    }
}
