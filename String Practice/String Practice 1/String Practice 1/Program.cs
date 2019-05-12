using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program 1
            string strResp = Console.ReadLine();
            Console.WriteLine("Your string was: " + strResp);
            Console.ReadLine();

            //program 2
            string strInput = Console.ReadLine();
            int intLength = strInput.Length;
            Console.WriteLine("Length of the string is: " + intLength.ToString());
            Console.ReadLine();

            //program 3
            string strInput1 = Console.ReadLine();
            Console.WriteLine("The characters of the string are:");
            for (int e = 0; e < strInput.Length; e++)
            {
                Console.Write(strInput1[e] + " ");
            }
            Console.ReadLine();

            //program 4
            string strInput2 = Console.ReadLine();
            Console.WriteLine("The characters of the string are: ");
            for (int p = strInput.Length - 1; p >= 0; p--)
            {
                Console.Write(strInput2[p] + " ");
            }
            Console.ReadLine();

            //program 5
            string strInput3 = Console.ReadLine();
            int i = 1;
            foreach (char c in strInput3)
            {
                if (c == ' ')
                {
                    i++;
                }
                else
                {

                }
            }
            Console.WriteLine("Total number of words in the string is: " + i.ToString());
            Console.ReadLine();
        }
    }
}