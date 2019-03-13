using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    class Program
    {
        public static double[,] dblArray = new double[,] { { 1.2, 5.7, 9.4, 3.3 }, { 7.5, 3.2, 6.7, 8.1 }, { 6.1, 2.5, 4.7, 8.2 } };


        static void Main(string[] args)
        {
            Print();

            AddOne();

            Print();

            Console.ReadLine();
        }

        static void Print()
        {
            string rowOfInts = "";
            string columnsAndRow = "";
            for (int r = 0; r < dblArray.GetLength(0); r++)
            {
                String tempString = "";
                for (int c = 0; c < dblArray.GetLength(1); c++)
                {
                    rowOfInts = tempString + " " + dblArray[r, c];
                    tempString = rowOfInts;
                }
                columnsAndRow += rowOfInts + "\n";
            }
            Console.WriteLine(columnsAndRow);
        }

        static void AddOne()
        {
            for (int r = 0; r < dblArray.GetLength(0); r++)
            {
                for (int c = 0; c < dblArray.GetLength(1); c++)
                {
                    dblArray[r, c] += 1;
                }
            }
        }
    }
}