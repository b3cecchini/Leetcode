using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1493
    {
        public int LongestSubarray(int[] nums)
        {
            int zeros = 0;
            int longestWindow = 0;
            int start = 0;

            for(int i  = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zeros += 1;

                while (zeros > 1)
                {
                    zeros -= (nums[start] == 0 ? 1 : 0);
                    start++;
                }

                longestWindow = Math.Min(longestWindow, i - start);

            }

            return longestWindow;


            /*
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    i_zero = i;
                    if(zeros == 0) zeros++;
                    if (zeros == 1)
                    {
                        while (nums[i] == 0)
                        {
                            i++;
                        }
                    }
                }
            }
            */
            

        }

        private int findNextZero(int[] nums, int startIndex) 
        {
            for( int i = startIndex; i < nums.Length; i++ ) 
            {
                if (nums[i] == 0) return i;
            }
            return -1;
        }
    }
}
