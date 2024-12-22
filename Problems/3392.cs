using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _3392
    {
        public int CountSubarrays(int[] nums)
        { 
            int retval = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 1] % 2 == 0 && nums[i] + nums[i+2] == nums[i+1] / 2) retval++;
            }

            return retval;
        }
    }
}
