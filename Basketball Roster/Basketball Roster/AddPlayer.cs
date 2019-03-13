using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Roster
{
    class AddPlayer
    {
        public string FirstName
        { get; set; } //get value and set it as value of variable
        public string LastName
        { get; set; }
        public int height
        { get; set; }
        public int position
        { get; set; }
        private string year
        { get; set; }
        public string Year
        {
            get
            {

                return year;

            }

            set
            {
                if (value == "FR"||value == "SO" || value == "JR" || value == "SR") 
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException();
                }

            }
        }
    }
}