using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _645
    {
        public int[] FindErrorNums(int[] nums)
        {
            bool[] result = new bool[nums.Length];

            int duplicate = 0;
            foreach (int i in nums)
            {
                if (result[i-1])
                {
                    duplicate = i;
                }
                result[i-1] = true;
            }

            var leftOut = Array.IndexOf(result, false);

            return [duplicate, leftOut+1];

        }
    }
}
