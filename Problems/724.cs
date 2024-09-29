using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _724
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0, totalSum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                var rightSum = totalSum - leftSum - nums[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }


    }
}
