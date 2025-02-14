using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMax1
{
    public class Numbers
    {
        public int[] FindMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return new int[] { min, max };

        }
    }
}
