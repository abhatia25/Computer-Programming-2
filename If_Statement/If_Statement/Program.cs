using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            string line = Console.ReadLine();

            int value;
            Int32.TryParse(line, out value);

            if (value < 10)
            {
                Console.WriteLine("This number is too small.");
            }
            else
            {
                Console.WriteLine("This number is big enough.");
            }

            Console.ReadLine();
        }
    }
}
