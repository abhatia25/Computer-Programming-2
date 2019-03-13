using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            getInfo(name: "Whitney Willis", age: 16); //named parameter
        }

        private static void getInfo(int age, string name = "Taylor Cobb")
        {
            Console.WriteLine(name, age);
            Console.ReadLine();
        }
    }
}
