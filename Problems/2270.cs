using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2270
    {
        public int WaysToSplitArray(int[] nums)
        {
            long l = 0, r = 0;
            int retval = 0;

            foreach (int x in nums) r += x;
            
            for(int i = 0; i < nums.Length - 1; i++)
            {
                l += nums[i];
                r -= nums[i];
                if(l >= r) retval++;
            }
            return retval;
        }
    }
}
