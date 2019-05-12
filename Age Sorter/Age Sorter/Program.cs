using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            List<int> intAboveTwenty = new List<int>();
            List<int> intBelowTwenty = new List<int>();

            Random randgen = new Random();
            for (int i = 0; i < 100; i++)
            {
                intList.Add(randgen.Next(15, 23));
            }
            string strBelow = "";
            string strAbove = "";

            foreach (int i in intList)
            {
                if (i >= 20)
                {
                    intAboveTwenty.Add(i);
                }

                if (i < 20)
                {
                    intBelowTwenty.Add(i);
                }
            }

            foreach (int i in intBelowTwenty)
            {
                strBelow += i.ToString() + " ";
            }

            foreach (int i in intAboveTwenty)
            {
                strAbove += i.ToString() + " ";
            }
            Console.WriteLine("Number of members below 20 years of age: " + intBelowTwenty.Count.ToString());
            Console.WriteLine("Younger ages include: \n \n" + strBelow);

            Console.WriteLine("\nNumber of members at or above 20 years of age: " + intAboveTwenty.Count.ToString());
            Console.WriteLine("Older ages include: \n \n" + strAbove);

            Console.ReadLine();
        }
    }
}