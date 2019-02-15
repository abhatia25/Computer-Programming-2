using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storytime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You are in a haunted house and you need to escape" +
                "Chose a number between 1 and 3: ");

            string line = Console.ReadLine();

            int intValue;
            Int32.TryParse(line, out intValue);

            Console.Write("Enter an integer: ");

            string line1 = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
