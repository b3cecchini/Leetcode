using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2563
    {
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);

            // use sliding window. first sort the list

            var length = nums.Length;
            var j = length;
            var k = length;
            long ans = 0;

            // for each element calculate all valid pairs between two indices 
            // [0,1,4,4,5,7]
            // lower = 3
            // higher = 6
            for (var i = 0; i < length; ++i)
            {
                // i = 0
                // j = 6
                // k = 6
                // ans = 0
                
                for (j = Math.Max(j, i + 1); j - 1 /* 5*/ > i /*0*/ && nums[i] + nums[j - 1] >= lower; --j) ;
                for (k = Math.Max(k, i + 1); k - 1 >= j && nums[i] + nums[k - 1] > upper; --k) ;
                ans += k - j;
            }

            return ans;
        }
    }
}
