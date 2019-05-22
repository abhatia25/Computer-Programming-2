using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TJSLibrary;   // <---have to use the dll    ****
using System.IO;

//By: Aditya Bhatia and Kristin Wendorf
enum Services { NewPatientVisit = 1, CheckUp, DistemperShot, RabiesShot, WormShot, Spaying, Neutering}
namespace VetOffice
{
    public partial class Form1 : Form
    {
        
        Animal[] a = new Animal[30];   //AnimalTJS class is in the 3rdParty Library  TJSLibrary                                    
        int IDStart = 1004;                                                         //**** need to reference the library -------->
        int MAX = 0;  // MAX tracks actual number of instantiated records in the array
        int IDX = 0;  // IDX stores the specific array index found by a search method
        Random rID = new Random();
        int ID, i = 0;
        double yrAge = 0;
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
            int b = MAX;
            ID = genID(IDStart, b);
            a[b] = new Animal(ID, "Jump", 1, 0, 46.3, DateTime.Parse("05/24/2017"));  //Today's date(2 yrs ago)
            
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

            int c = MAX;
            a[c] = new Animal(ID, "Pat", 0, 0, 1.75, DateTime.Parse("05/24/2019"));
            ID = genID(IDStart, ++MAX);

            int d = MAX;
            a[d] = new Animal(ID, 0, 3);
            a[d].updWeight(4);
            ID = genID(IDStart, ++MAX);

            int f = MAX;
            a[f] = new Animal(ID, "Bull", 2, 2, 1.2, DateTime.Parse("05/24/2016"));
            ID = genID(IDStart, ++MAX);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //age client list 1 human year by making their birthday 1 year back in time
            for (int b = 0; b < MAX; b++)
                a[b].updBDay(a[b].getBDay().AddYears(-1));

            // add in any new clients or updates based on story,  because we made existing clients older,
            // are entered and validated as if they came in today
            int x = 1004;

            int i;
            for (i = 0; i < MAX - 1; i++)
                if (a[i].getAID() == x)
                    IDX = i;   //IDX is a global that tracks the found array index
            a[i].hlpCharge(6);
            a[i].hlpAnimalGender(3);
            
            int g = MAX;
            a[g] = new Animal(ID, "Goldie", 0, 2, 0.1, DateTime.Parse("05/24/2019"));
            ID = genID(IDStart, ++MAX);
            //this code does not work currently
            int h = MAX;
            a[h] = new Animal(ID, 2, 0);
            a[h].Name = "Slick";
            a[h].hlpCharge(4);
            a[h].updWeight(81.4);
            ID = genID(IDStart, ++MAX);

            
            int j = MAX;
            a[j] = new Animal(ID, "Tom", 2, 3, 3.5, DateTime.Parse("05/24/2016"));
            ID = genID(IDStart, ++MAX);


        }

        private void button3_Click(object sender, EventArgs e) //still need to do
        {
            // client list 2 human years,   add in any records or updates from story for 4th year
            for (int j = 0; j < MAX; j++)
                a[j].updBDay(a[j].getBDay().AddYears(-2));

            int x = 1004;

            int i;
            for (i = 0; i < MAX - 1; i++)
                if (a[i].getAID() == x)
                    IDX = i;   //IDX is a global that tracks the found array index
            a[i].updWeight(89.4);

            listBox1.ScrollAlwaysVisible = true;

            int aa = MAX;
            for(int t = 7; t <= 18+7; t++)
            {
                int j = 0;
                switch (j)
                {
                    case 1:
                        int ab = MAX;
                        a[ab] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ab].Name = t.ToString();
                        a[ab].updWeight(0.1);
                        break;
                    case 2:
                        int ac = MAX;
                        a[ac] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ac].Name = t.ToString();
                        a[ac].updWeight(0.1);
                        break;
                    case 3:
                        int ad = MAX;
                        a[ad] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ad].Name = t.ToString();
                        a[ad].updWeight(0.1);
                        break;
                    case 4:
                        int ae = MAX;
                        a[ae] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ae].Name = t.ToString();
                        a[ae].updWeight(0.1);
                        break;
                    case 5:
                        int af = MAX;
                        a[af] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[af].Name = t.ToString();
                        a[af].updWeight(0.1);
                        break;
                    case 6:
                        int ag = MAX;
                        a[ag] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ag].Name = t.ToString();
                        a[ag].updWeight(0.1);
                        break;
                    case 7:
                        int ah = MAX;
                        a[ah] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ah].Name = t.ToString();
                        a[ah].updWeight(0.1);
                        break;
                    case 8:
                        int ak = MAX;
                        a[ak] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ak].Name = t.ToString();
                        a[ak].updWeight(0.1);
                        break;
                    case 9:
                        int ahk = MAX;
                        a[ahk] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahk].Name = t.ToString();
                        a[ahk].updWeight(0.1);
                        break;
                    case 10:
                        int ahh = MAX;
                        a[ahh] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahh].Name = t.ToString();
                        a[ahh].updWeight(0.1);
                        break;
                    case 11:
                        int ahy = MAX;
                        a[ahy] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahy].Name = t.ToString();
                        a[ahy].updWeight(0.1);
                        break;
                    case 12:
                        int ahp = MAX;
                        a[ahp] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahp].Name = t.ToString();
                        a[ahp].updWeight(0.1);
                        break;
                    case 13:
                        int aht = MAX;
                        a[aht] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[aht].Name = t.ToString();
                        a[aht].updWeight(0.1);
                        break;
                    case 14:
                        int ahw = MAX;
                        a[ahw] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahw].Name = t.ToString();
                        a[ahw].updWeight(0.1);
                        break;
                    case 15:
                        int aha = MAX;
                        a[aha] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[aha].Name = t.ToString();
                        a[aha].updWeight(0.1);
                        break;
                    case 16:
                        int ahr = MAX;
                        a[ahr] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahr].Name = t.ToString();
                        a[ahr].updWeight(0.1);
                        break;
                    case 17:
                        int ahq = MAX;
                        a[ahq] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ahq].Name = t.ToString();
                        a[ahq].updWeight(0.1);
                        break;
                    case 0:
                        int ai = MAX;
                        a[ai] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[ai].Name = t.ToString();
                        a[ai].updWeight(0.1);
                        break;
                    default:
                        int aj = MAX;
                        a[aj] = new Animal(ID);
                        ID = genID(IDStart, ++MAX);
                        a[aj].Name = t.ToString();
                        a[aj].updWeight(0.1);
                        break;
                }
                j++;
            }
        }

        private void button4_Click(object sender, EventArgs e)   //displays complete client list to ListBox
        {
            //dump data to list box      student don't change
            CreateFile();

            listBox1.Items.Clear();
            listBox1.Items.Add("ID#\tName\tSex\tType\tAge\tWeight");
            for (int j = 0; j < MAX; j++)
            {
                ID = a[j].getAID();
                yrAge = a[j].hlpGetAgeA(DateTime.Now); //<--change effDate to
                yrAge = Math.Round(yrAge, 2);
                asex = a[j].getSex("");
                what = a[j].getType("");
                petName = a[j].getName();

                listBox1.Items.Add(ID.ToString() + "\t" + petName + "\t" + asex + "\t" + what +
                    "\t" + yrAge.ToString() + "\t" + a[j].getWeight().ToString("###.0"));
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
            
            int j = 0;
            switch (j)
            {
                case 1:
                    int n = MAX;
                    a[n] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[n].Name = txtBox1.Text;
                    break;
                case 2:
                    int o = MAX;
                    a[o] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[o].Name = txtBox1.Text;
                    break;
                case 3:
                    int p = MAX;
                    a[p] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[p].Name = txtBox1.Text;
                    break;
                case 4:
                    int q = MAX;
                    a[q] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[q].Name = txtBox1.Text;
                    break;
                case 5:
                    int r = MAX;
                    a[r] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[r].Name = txtBox1.Text;
                    break;
                case 6:
                    int s = MAX;
                    a[s] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[s].Name = txtBox1.Text;
                    break;
                case 7:
                    int t = MAX;
                    a[t] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[t].Name = txtBox1.Text;
                    break;
                case 0:
                    int m = MAX;
                    a[m] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[m].Name = txtBox1.Text;
                    break;
                default:
                    MessageBox.Show("No more animals can be created!");
                    break;

            }
            j++;
        }

        private void btnBrood_Click(object sender, EventArgs e)//STUDENT add Code for a NEW brood of animals
        {
            int j = 0;
            switch (j)
            {
                case 1:
                    int u = MAX;
                    a[u] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[u].Name = txtBox1.Text;
                    break;
                case 2:
                    int w = MAX;
                    a[w] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[w].Name = txtBox1.Text;
                    break;
                case 3:
                    int z = MAX;
                    a[z] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[z].Name = txtBox1.Text;
                    break;
                case 4:
                    int y = MAX;
                    a[y] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[y].Name = txtBox1.Text;
                    break;
                case 0:
                    int v = MAX;
                    a[v] = new Animal(ID);
                    ID = genID(IDStart, ++MAX);
                    a[v].Name = txtBox1.Text;
                    break;
                default:
                    MessageBox.Show("No more animals can be created!");
                    break;

            }
            j++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)//STUDENT add Code for an animal returning visit
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

            listBox1.Items.Clear();
            listBox1.Items.Add("ID#\tName\tSex\tType\tAge\tWeight");
            i = IDX;
            ID = a[i].getAID();
            yrAge = a[i].hlpGetAgeA(DateTime.Now); //<--change effDate to
            yrAge = Math.Round(yrAge, 2);
            asex = a[i].getSex("");
            what = a[i].getType("");
            petName = a[i].getName();

            listBox1.Items.Add(ID.ToString() + "\t" + petName + "\t" + asex + "\t" + what +
                "\t" + yrAge.ToString() + "\t" + a[i].getWeight().ToString("###.0"));




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

            listBox1.Items.Clear();
            listBox1.Items.Add("ID#\tName\tSex\tType\tAge\tWeight");
            i = IDX;
                ID = a[i].getAID();
                yrAge = a[i].hlpGetAgeA(DateTime.Now); //<--change effDate to
                yrAge = Math.Round(yrAge, 2);
                asex = a[i].getSex("");
                what = a[i].getType("");
                petName = a[i].getName();

                listBox1.Items.Add(ID.ToString() + "\t" + petName + "\t" + asex + "\t" + what +
                    "\t" + yrAge.ToString() + "\t" + a[i].getWeight().ToString("###.0"));
        }

        public int genID(int start, int i)  //this method provided to generate valid AID numbers based on the array index i and a valid starting point
        {
            return (start + 20 * i);
        }

        private void CreateFile()
        {
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\TEST\\VetDB.txt";
            FileStream fs = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                byte[] bText = System.Text.Encoding.ASCII.GetBytes(listBox1.Items[i].ToString());
                fs.Write(bText, 0, bText.Length);
            }
            
            fs.Close();
        }

        private void InvoiceData()
        {
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\TEST\\Invoice_" + ID.ToString() + "_" + petName + ".txt";
            FileStream fs = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            byte[] bText = System.Text.Encoding.ASCII.GetBytes((ID.ToString()) + ":" + (petName) + ":" +  Services.CheckUp + ":" + a[ID].hlpCharge((int)Services.CheckUp));
            fs.Write(bText, 0, bText.Length);
            fs.Close();
        }
    }
}