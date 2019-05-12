using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.age = 3;
            dog1.breed = "German Shepard";
            Dog dog2 = new Dog();
            dog2.age = 1;
            dog2.breed = "Yorkie";
            Dog dog3 = new Dog();
            dog3.age = 5;
            dog3.breed = "Golden Labrador";
            List<Dog> dogList = new List<Dog>();
            dogList.Add(dog1);
            dogList.Add(dog2);
            dogList.Add(dog3);
            foreach (Dog d in dogList)
                Console.WriteLine(d.ToString());
            Console.ReadLine();

            List<string> dogList2 = new List<string>();
            dogList2.Add("spaniel");
            dogList2.Add("beagle");
            dogList2.Insert(1, "dalmatian");
            foreach (string d in dogList2)
                Console.WriteLine(d.ToString());
            Console.ReadLine();
        }
    }

    class Dog
    {
        public int age;
        public string breed;
    }
}
