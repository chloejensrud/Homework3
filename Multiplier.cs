using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyingValuesBySum
{
    public class Multiplier
    {
        public int[] MultiplyLength(int[] arr)
        {
            int length = arr.Length;
            int[] result = new int[length];

            int i = 0;
            foreach (int num in arr)
            { result[i++] = num * length; }
            return result;
        }
    }
}
