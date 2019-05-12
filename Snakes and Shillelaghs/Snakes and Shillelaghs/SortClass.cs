using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Shillelaghs
{
    class SortClass //class #2
    {
        public static void SortMethod() //method to sort the 2D array into 2 smaller 1D arrays
        {
            int d = 0;
            foreach (int i in frmInstructions.array[d])
            {
                frmInstructions.array1[d] = i;
                d++;
            }
            d = 0;
            foreach (int i in frmInstructions.array[d])
            {
                frmInstructions.array2[d] = i;
                d++;
            }
        }
    }
}
