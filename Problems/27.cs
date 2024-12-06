using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int p = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[p] = nums[i];
                    p++;
                }
            }

            return p;
        }
    }
}
