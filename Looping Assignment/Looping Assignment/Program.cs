using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Assignment //Aditya and Alexander
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 10; i+=2); //#1

            for (i = 10; i >= 0; i--); //#2

            int I, X;
            X = 0;
            Int32.TryParse(Console.ReadLine(), out I); //#3
            while (I != -1)
            {
                X++;
            }

            string L, W;
            W = "0";
            L = Console.ReadLine();
            do
            {
                W = "0000000000";
            } while (L != "stop"); //#4

            

        }
    }
}
