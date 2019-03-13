using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator
{
    class Weight
    {
        private double intWeight;
        private double additionalCost;
        public double weight
        { get; set; }

        public double dblTotal;
        public void Total()
        {
            intWeight = Convert.ToInt32(weight);

            if (intWeight > 5.99)
            {
                dblTotal = 6.79;

                intWeight = intWeight - 5;

                additionalCost = intWeight * 0.49;
                dblTotal += additionalCost;
            }
            else
            {
                dblTotal = 6.79;
            }
        }
    }
}