using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadEnvEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion; 
            PlatformID osID = os.Platform;
            string[] lDrives = Environment.GetLogicalDrives(); string drivStr = "";
            foreach (string driv in lDrives)
            { drivStr += driv + " "; }
            drivStr = drivStr.Trim(); LB.Items.Add("Op Sys: " +os);
            LB.Items.Add("Op Sys ID: " + osID);
            LB.Items.Add("CLRVer: " + Environment.Version);
            LB.Items.Add("Mach Name: " + Environment.MachineName);
            LB.Items.Add("");
            // just a blank line for sake of neatness
            LB.Items.Add("User ID:\t\t" + Environment.UserName);
            LB.Items.Add("CurrentDir:\t" + Environment.CurrentDirectory);
            LB.Items.Add("Drives Present:\t" + drivStr);
        }
    }
}
