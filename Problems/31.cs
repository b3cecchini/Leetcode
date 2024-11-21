using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _31
    {
        /*
            1. Find the largest index k such that a[k] < a[k + 1]. If no such index exists, the permutation is the last permutation.
            
            2. Find the largest index l greater than k such that a[k] < a[l].
            
            3. Swap the value of a[k] with that of a[l].
            
            4. Reverse the sequence from a[k + 1] up to and including the final element a[n].
         */
        public void NextPermutation(int[] nums)
        {
            int start = 0;
            for (int i = nums.Length - 1; i >= 1; i--)
            {
                if (nums[i] > nums[i-1])
                {
                    start = i - 1;
                    break;
                }
            }
            int end = nums.Length - 1;
            for (int i = nums.Length - 1; i > start; i--)
            {
                if (nums[i] > nums[start])
                {
                    end = i;
                    break;
                }
            }

            // now we have start and end
            // need to reverse the array between the to elements

            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
