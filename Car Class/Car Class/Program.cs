using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Car car = new Car("Joe's Car");
            car.Start(); //method, . is access modifier
            Console.WriteLine(car.GetName());

            //wait for user to hit enter before closing console
            Console.ReadLine();
        }
    }
}