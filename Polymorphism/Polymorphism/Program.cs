using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Talk();
            a1.Sing();
            a1.Greet();
            Console.ReadLine();

            /*Output
                Animal constructor
                Animal talk
                Animal song
                Animal says Hello
            */

            Animal a2 = new Dog();
            a2.Talk();
            a2.Sing();
            a2.Greet();
            Console.ReadLine();

            /*Output
                Animal constructor
                Dog constructor
                Animal talk
                Dog song
                Animal says Hello
            */

            Dog d1 = new Dog();
            d1.Talk();
            d1.Sing();
            d1.Greet();
            Console.ReadLine();

            /*Output
                Animal constructor
                Dog constructor
                Dog talk
                Dog song
                Animal says Hello
            */
        }
    }
}
