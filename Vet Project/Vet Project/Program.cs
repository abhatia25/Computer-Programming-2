using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJSLibrary;

namespace Vet_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            int id = 1004;
            Animal[] a = new Animal[10];
            Console.ReadLine();
            //a[0] = new Animal(id, "stecker", 2, 0, 195.5, DateTime.Parse("11/17/1951"));
            //id += 4;
            //a[1] = new Animal();   //  AID
            //a[2] = new Animal(id);
            //id += 4;
            //a[3] = new Animal(id, "Fred", 0);
            //id += 4;
            //a[4] = new Animal(id, 1, 1);
            //id += 4;
            //a[5] = new Animal(id, "Jump", 1, 0, 47.5, DateTime.Parse("01/05/1989"));
            //id += 4;
            ////all above should work
            //// now several that have invalid data
            //a[6] = new Animal(1001);   //AID
            //a[7] = new Animal(id, 7, 12);
            //id += 4;
            //a[8] = new Animal(id, "fido", 7);
            //id += 4;
            //a[9] = new Animal(id, "fido", 7, 7, -36.9, DateTime.Parse("01/07/2020"));
            //id += 4;

            ////put 7 constructor test calls here
            //for (int i = 0; i < a.Length; i++)
            //    Console.WriteLine(a[i].getAID().ToString() + " : " +
            //        a[i].getName().ToString() + " : " +
            //        a[i].getSex().ToString() + " : " +
            //        a[i].getType().ToString() + " : " +
            //        a[i].getWeight().ToString() + " : " +
            //        a[i].getBDay().ToString());

            //Console.ReadLine();
            ////now some updater calls
            //for (int i = 0; i < a.Length; i++)  //  Check it out what is going on here?
            //    if (a[i].getAID() < 0)
            //    {
            //        a[i].updAID(id);
            //        id += 4;
            //    }
            ////put some updaters and writelines here
            //a[6].updBDay(DateTime.Parse("02/18/2028"));
            //DateTime x = a[1].updBDay(DateTime.Parse("02/18/1998"));

            //// now let's display our data records after the various modifications to see if all is well
            ////  so  put some more getters and writelines here

            //for (int i = 0; i < a.Length; i++)
            //    Console.WriteLine(a[i].getAID().ToString() + " : " +
            //        a[i].getName().ToString() + " : " +
            //        a[i].getSex("") + " : " +
            //        a[i].getType("") + " : " +
            //        a[i].getWeight().ToString() + " : " +
            //        a[i].getBDay().ToString() + " : " +
            //        a[i].hlpGetAgeA(DateTime.Now).ToString() + " yrs old.");

            //String msg = "Your weight has changed significantly since last visit.";
            //String s1 = "\n\rYou have ";
            //String s2 = " more than ";
            //String s3 = "GAINED";
            //String s4 = "LOST";
            //String s6 = "5% !!";
            //String s7 = "10% !!!!";
            //int y = a[0].updWeight(220.0);
            //if (y != 0)
            //{
            //    msg += s1;
            //    msg += y > 0 ? s3 : s4;
            //    msg += s2;
            //    msg += Math.Abs(y) > 1 ? s7 : s6;
            //    Console.WriteLine(msg);
            //}
            //Console.ReadLine();
        }
    }
}
