using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string theName;
            double theGPA;
            string letterGrade = "";
            try
            {
                theName = getName();
                theGPA = getGPA();
                if(theGPA < 1)
                {
                    letterGrade = "F";
                }
                else if(theGPA >= 1 && theGPA <= 1.99)
                {
                    letterGrade = "D";
                }
                else if (theGPA >= 2 && theGPA <= 2.99)
                {
                    letterGrade = "C";
                }
                else if (theGPA >= 3 && theGPA <= 3.99)
                {
                    letterGrade = "B";
                }
                else if (theGPA == 4)
                {
                    letterGrade = "A";
                }

                Console.WriteLine("Letter grade: " + letterGrade);
                Console.ReadLine();
            }
            catch (GPAOutOfRange gpa)
            {
                Console.WriteLine(gpa.Message);
            }
        }

        public static string getName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static double getGPA()
        {
            double currentGPA = 0;
            try
            {
                Console.WriteLine("Enter your GPA:");
                currentGPA = Convert.ToDouble(Console.ReadLine());
                if (currentGPA >= 0.00 && currentGPA <= 4.00) //check for valid input
                {
                    return currentGPA;
                }
                else
                {
                    throw new GPAOutOfRange(); //throws an exception for a bad GPA
                }
            }
            catch (FormatException gpa) // catches bad input other than a GPA out of range
            {
                Console.WriteLine(gpa.Message); //from the exception class
                return 0;
            }
        }
    }

    class GPAOutOfRange : Exception //inherits from the Exception class
    {
        public GPAOutOfRange() : base("The GPA you entered is not between 0.00 and 4.00. Please try again.") //message to be displayed to user
        {
        }
    }
}