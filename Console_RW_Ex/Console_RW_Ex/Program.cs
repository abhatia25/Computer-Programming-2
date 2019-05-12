using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RW_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\rType something and enter, \n\r(a QQ at beginning of line will teriminate.)");
                string s = Console.ReadLine();
                if (s.Substring(0, 2) == "QQ")
                    break;
                Console.WriteLine("BEGIN..." + s + "...END");
                //if last line of code is a Console.WriteLine(), program ends as soon as it is displayed
            }
        }
    }
}
