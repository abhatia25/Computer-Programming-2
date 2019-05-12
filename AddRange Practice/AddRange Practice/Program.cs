using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddRange_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "blue", "pink", "purple" };
            Console.WriteLine("The colors in the first list are: ");
            foreach (string strString in colors)
            {
                Console.Write(strString + "  ");
            }

            List<string> colors2 = new List<string>() { "navy", "violet" };
            Console.WriteLine("\nThe colors in the second list are: ");
            foreach (string strString in colors2)
            {
                Console.Write(strString + "  ");
            }

            colors.AddRange(colors2);
            Console.WriteLine("\nThe colors in the first list after using AddRange are: ");
            foreach (string strString in colors)
            {
                Console.Write(strString + "  ");
            }

            Console.ReadLine();
        }
    }
}