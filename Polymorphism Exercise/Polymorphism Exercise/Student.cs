using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Exercise
{
    class Student
    {
        public int number1 = 0;
        public int number2 = 0;
        public int number3 = 0;

        public int AverageGr = 0;
        public int SumGr = 0;
        
        public void WriteNumbers()
        {
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);
            Console.WriteLine("Number 3: " + number3);
        }
        public void Average()
        {
            AverageGr = (number1 + number2 + number3) / 3;
            Console.WriteLine("Average: " + AverageGr);
            return;
        }
    }

    class StudentSum: Student
    {
        public void Sum()
        {
            SumGr = number1 + number2 + number3;
            Console.WriteLine("Sum: " + SumGr);
            return;
        }

    }
}