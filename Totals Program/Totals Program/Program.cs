using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totals_Program
{
    class Program
    {
        public static int[,] intArray = new int[,] { { 1, 7, 5, 9 }, { 2, 4, 3, 8 }, { 5, 9, 10, 2 } };
        static void Main(string[] args)
        {
            Print();
            TotalAndAverage();
            Console.ReadLine();
        }


        static void TotalAndAverage()
        {
            int total = 0;
            int average = 0;
            for (int r = 0; r < intArray.GetLength(0); r++)
            {
                total = 0;
                average = 0;
                for (int c = 0; c < intArray.GetLength(1); c++)
                {
                    total += intArray[r, c];
                }
                average = total / intArray.GetLength(1);
                Console.WriteLine("Total for row " + r + " is " + total + " and average is " + average);
            }
        }

        static void Print()
        {
            string rowOfInts = "";
            string columnsAndRow = "";
            for (int r = 0; r < intArray.GetLength(0); r++)
            {
                String tempString = "";
                for (int c = 0; c < intArray.GetLength(1); c++)
                {
                    rowOfInts = tempString + " " + intArray[r, c];
                    tempString = rowOfInts;
                }
                columnsAndRow += rowOfInts + "\n";
            }
            Console.WriteLine(columnsAndRow);
        }
    }
}