using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] nums = new double[] {0.05, 0.04, 0.03, 0.02, 0.01};
            //Console.WriteLine(nums[1] + "f");
            //Console.ReadLine();

            int[,] intArray = new int[,] {{1,5,6}, {2,4,3}};
            Console.WriteLine(Convert.ToString(intArray[1, 2]));

            Console.ReadLine();
        }
    }
}
