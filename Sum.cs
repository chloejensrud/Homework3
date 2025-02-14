using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAbsoluteValue
{
    public class Sum
    {
        public int GetAbsSum(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            { sum += Math.Abs(num); }
            return sum;
        }
    }
}
