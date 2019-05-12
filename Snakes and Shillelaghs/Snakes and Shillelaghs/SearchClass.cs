using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Shillelaghs
{
    class SearchClass
    {
        public static void Search()
        {
            frmLevel2.result = 0;
            int intRandNum = 0;
            Random randnum = new Random();
            intRandNum = randnum.Next(1, 7);
            frmLevel2.result = frmLevel2.result + Array.BinarySearch(frmInstructions.array1, intRandNum);
            frmLevel2.result = frmLevel2.result + Array.BinarySearch(frmInstructions.array2, intRandNum);
            if (frmLevel2.result < 0)
            {
                frmLevel2.result = Math.Abs(frmLevel2.result);
            }
        }
    }
}
