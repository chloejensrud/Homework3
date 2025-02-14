using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDs
{
    public class Counter
    {
        public int CountDs(string sentance)
        {
            int count = 0;
            foreach (char c in sentance)
            {
                if (char.ToLower(c) == 'd')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
