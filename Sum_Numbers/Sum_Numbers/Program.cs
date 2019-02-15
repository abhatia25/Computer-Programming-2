using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            string line = Console.ReadLine();

            int intValue;
            Int32.TryParse(line, out intValue);

            Console.Write("Enter an integer: ");

            string line1 = Console.ReadLine();

            int intValue1;
            Int32.TryParse(line1, out intValue1);

            Console.WriteLine(intValue/intValue1);


            Console.ReadLine();
        }
    }
}
