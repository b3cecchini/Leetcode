using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1732
    {
        public int LargestAltitude(int[] gain)
        {
            int currentAlt = 0;
            int maxSum = 0;
            foreach (int i in gain)
            {
                currentAlt = currentAlt + i;
                if(currentAlt > maxSum)
                {
                    // Changed from using Math.max() and increased memory and execution time by about 15-20%
                    maxSum = currentAlt;
                }
            }

            return maxSum;
        }
    }
}
