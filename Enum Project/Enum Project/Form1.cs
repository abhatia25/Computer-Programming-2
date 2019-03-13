using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum MenuItems {Hamburger, Cheeseburger, BigMac, QuarterPounder,  QuarterPounderCheese, Fries, CocaCola, Milkshake};
enum Days {Monday, Tuesday, Wednesday, Thursday, Friday};

namespace Enum_Project
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        int intSpecial = (int)Days.Thursday;
        string[] MenuArray = Enum.GetNames(typeof(MenuItems));
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblPrice.Text = "Price: $0.00";
            if (MenuArray[intSpecial] == "QuarterPounder")
            {
                lblSpecial.Text = "Special: $0.50 off " + "Quarter Pounder";
            }
            else if (MenuArray[intSpecial] == "QuarterPounderCheese")
            {
                lblSpecial.Text = "Special: $0.50 off " + "Quarter Pounder With Cheese";
            }
            else
            {
                lblSpecial.Text = "Special: $0.50 off " + MenuArray[intSpecial];
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double Price = 0;
            int SpecialMeal = 0;

            if (radHamburger.Checked)
                {
                SpecialMeal = 0;
                Price = 4;
                }
            else if (radCheeseburger.Checked)
                {
                SpecialMeal = 1;
                Price = 5;
                }
            else if (radBigMac.Checked)
                {
                SpecialMeal = 2;
                Price = 8;
                }
            else if (radQP.Checked)
                {
                SpecialMeal = 3;
                Price = 6;
                }
            else if (radQPCheese.Checked)
                {
                SpecialMeal = 4;
                Price = 7;
                }
            else if (radFries.Checked)
                {
                SpecialMeal = 5;
                Price = 3;
                }
            else if (radCocaCola.Checked)
                {
                SpecialMeal = 5;
                Price = 1;
                }
            else if (radMilkshake.Checked)
                {
                SpecialMeal = 5;
                Price = 2;
                }

            if (intSpecial == SpecialMeal)
            {
                Price -= 0.50;
            }

            string strPrice = Price.ToString("C2");

            lblPrice.Text = "Price: " + strPrice;
        }
    }
}