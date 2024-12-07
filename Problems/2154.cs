using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2154
    {
        public int FindFinalValue(int[] nums, int original)
        {
            var l = nums.ToList();

            while(true)
            {
                if (l.Contains(original)) original *= 2;
                else break;
            }
            return original;
        }
    }
}
