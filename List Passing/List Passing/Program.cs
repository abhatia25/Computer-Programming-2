using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Passing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("List of numbers: ");

            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.Write(numbers[i] + " ");
            }

            AddToList(numbers);

            Console.WriteLine("\nList of numbers after calling AddToNumbers: ");

            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }

        public static void AddToList(List<int> list)
        {
            List<int> newNumbers = new List<int>() { 10, 11, 12, 13, 14, 15 };
            list.AddRange(newNumbers);
        }
    }
}
