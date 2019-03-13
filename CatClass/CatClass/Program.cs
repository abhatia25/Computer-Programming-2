                     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMiau();
            Cat secondCat = new Cat("Pepy", "red", "soft");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1} and {2}", secondCat.Name, secondCat.Color, secondCat.Texture);
            Cat thirdCat = new Cat("Jimmy", "green", "fluffy");
            thirdCat.SayMiau();
            Console.WriteLine("Cat {0} is {1} and {2}.", thirdCat.Name, thirdCat.Color, thirdCat.Texture);
            Console.ReadLine();
        }
    }
}
