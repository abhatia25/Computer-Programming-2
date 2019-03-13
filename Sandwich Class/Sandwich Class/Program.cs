using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sandwich_Type = Console.ReadLine();
            Sandwich NewSandwich = new Sandwich();
            NewSandwich.Sandwich_Type = Sandwich_Type;
        }
    }
}
