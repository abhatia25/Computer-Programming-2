using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TJSLibrary;   // <---have to use the dll    ****

namespace VetOffice
{
    public partial class Form1 : Form
    {
        Animal[] a = new Animal[30];   //AnimalTJS class is in the 3rdParty Library  TJSLibrary                                    
        int IDStart = 1004;                                                         //**** need to reference the library -------->
        int MAX = 0;  // MAX tracks actual number of instantiated records in the array
        int IDX = 0;  // IDX stores the specific array index found by a search method
        Random rID = new Random();
        int ID, yrAge, i = 0;
        String petName, asex, what;

        DateTime effDate = DateTime.Now;


        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("T J Stecker - 11/20/13 - R1.0 Animal Tester");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //Construct and Update Animals from the year 1 script
            //                      ID  Name Sex  Type Weight  Birthday   
            int j = MAX;
            ID = genID(IDStart,j);
            a[j] = new Animal(ID, "Jump", 1, 0, 46.3, DateTime.Parse("03/16/2013"));  //Today's date(2 yrs ago)
            /* The above 6 parameter constructor is used because we know all info
             * But what if we only knew name and type?
             * Then we would construct with what we know and update rest later
             * or possibly supply our own default unknowns with the 6 parameter version.
             * one example over time might be
             * a[j] = new Animal(ID, "Jump", 1);
             * and later, 
             * int code = a[j].updWeight(46.3);  // remember, that an int is returned from updWeight
             * a[j].updSex(1);
             * a[j].updBDay(DateTime.Parse("01/05/1989"));
             * */
            ID = genID(IDStart, ++MAX);//these operations have to be performed after a new animal is constructed
                    // in order for this hard-coded pre-sized array approach to work
                    // traditional array element Length logic could be used but then since our Length is more
                    // than the number of active animals we would need to subtract the NonMax ones out, using MAX is easier
                    // also, this code example is incrementing the ID for the next one to use it as well as the MAX,
                    //at bottom of listing is a method which generates a +20 ID based on the array index, use it instead if you want.
            








            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //age client list 1 human year by making their birthday 1 year back in time
            for (i = 0; i < MAX; i++)
                a[i].updBDay(a[i].getBDay().AddYears(-1));

            // add in any new clients or updates based on story,  because we made existing clients older,
            // are entered and validated as if they came in today










        }

        private void button3_Click(object sender, EventArgs e)
        {
            // client list 2 human years,   add in any records or updates from story for 4th year








    
        }

        private void button4_Click(object sender, EventArgs e)   //displays complete client list to ListBox
        {
            //dump data to list box      student don't change
            listBox1.Items.Clear();
            listBox1.Items.Add("ID#\tName\tSex\tType\tAge\tWeight");
            for (i = 0; i < MAX; i++)
            {
                ID = a[i].getAID();
                yrAge = a[i].hlpGetAgeA(DateTime.Now); //<--change effDate to
                asex = a[i].getSex("");
                what = a[i].getType("");
                petName = a[i].getName();

                listBox1.Items.Add(ID.ToString() + "\t" + petName + "\t" + asex + "\t" + what +
                    "\t" + yrAge.ToString() + "\t" + a[i].getWeight().ToString("###.0"));
            }
        }

        private void ageClients1HYrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Not MODIFY THIS Method
            // update 1 human years, whole client list
            //age client list 1 human year
            for (i = 0; i < MAX; i++)
                a[i].updBDay(a[i].getBDay().AddYears(-1)); 
        } 

        private void ageClients2HYrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Not MODIFY THIS Method
            // update 2 human years, whole client list
            //age client list 1 human year
            for (i = 0; i < MAX; i++)
                a[i].updBDay(a[i].getBDay().AddYears(-2));
        }

        private void ageClients3HYrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Not MODIFY THIS Method
            // update 3 human years, whole client list
            //age client list 1 human year
            for (i = 0; i < MAX; i++)
                a[i].updBDay(a[i].getBDay().AddYears(-3));
        }

        private void btnNew_Click(object sender, EventArgs e)  //STUDENT add Code for NEW animal
        {






        }

        private void btnBrood_Click(object sender, EventArgs e)//STUDENT add Code for a NEW brood of animals
        {






        }

        private void btnReturn_Click(object sender, EventArgs e)//STUDENT add Code for an animal returning visit
        {






        }
        private void btnLookUp_Click(object sender, EventArgs e)//STUDENT example code for looking up a patient via AID
        {
            int x;

            try
            {
              x = Convert.ToInt32(txtBox1.Text);
                if (x < 1004 || x > 9996 || x % 4 != 0)
                {
                    MessageBox.Show("Sorry, UID must be in range of 1004 to 9996 and multiple of 4");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Sorry, but that is not a valid Patient ID, Please Try Again!");
                return;
            }

            int i;
            for (i = 0; i < MAX - 1; i++)
                if (a[i].getAID() == x)
                    IDX = i;   //IDX is a global that tracks the found array index
        }

        public int genID(int start, int i)  //this method provided to generate valid AID numbers based on the array index i and a valid starting point
        {
            return (start + 20 * i);
        }




    }
}
