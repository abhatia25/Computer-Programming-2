using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Shillelaghs
{
    class Distraction //class #1
    {
        public static void NumberGen() //method to generate random number for distraction
        {
            Random rnd = new Random();
            frmInstructions.randomnumber = rnd.Next(1, 5); 
        }

        public static void Search() //method to search for random number in distraction +list
        {
            frmInstructions.Distractor.Sort();
            frmInstructions.index = frmInstructions.Distractor.BinarySearch(frmInstructions.randomnumber);
        }
    }
}
