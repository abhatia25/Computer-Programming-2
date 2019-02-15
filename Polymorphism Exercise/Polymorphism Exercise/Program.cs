using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Student 1");
            StudentSum student = new StudentSum();
            Random rnd = new Random();
            student.number1 = rnd.Next(0, 101);
            student.number2 = rnd.Next(0, 101);
            student.number3 = rnd.Next(0, 101);
            student.WriteNumbers();
            student.Average();
            student.Sum();
            Console.Write("\n");

            Console.WriteLine("Student 2");
            StudentSum student1 = new StudentSum();
            student1.number1 = rnd.Next(0, 101);
            student1.number2 = rnd.Next(0, 101);
            student1.number3 = rnd.Next(0, 101);
            student1.WriteNumbers();
            student1.Average();
            student1.Sum();
            Console.Write("\n");

            Console.WriteLine("Student 3");
            StudentSum student2 = new StudentSum();
            student2.number1 = rnd.Next(0, 101);
            student2.number2 = rnd.Next(0, 101);
            student2.number3 = rnd.Next(0, 101);
            student2.WriteNumbers();
            student2.Average();
            student2.Sum();
            Console.Write("\n");

            Console.WriteLine("Student 4");
            StudentSum student3 = new StudentSum();
            student3.number1 = rnd.Next(0, 101);
            student3.number2 = rnd.Next(0, 101);
            student3.number3 = rnd.Next(0, 101);
            student3.WriteNumbers();
            student3.Average();
            student3.Sum();
            Console.Write("\n");

            Console.ReadLine();
        }
    }
}