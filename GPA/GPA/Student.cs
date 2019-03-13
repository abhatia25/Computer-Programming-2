using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    class Student
    {
        public string Name;
        private double gpa;
        public double GPA
        {
            get
            {

                return gpa;

            }

            set
            {
                if ((value >= 0.00) && (value <= 4.00)) //check GPA range
                {
                    gpa = value;
                }
                else
                {
                    throw new ArgumentException(); //if out of range
                }

            }
        }
    }
}