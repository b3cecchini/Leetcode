using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _643
    {
        public double FindMaxAverage_(int[] nums, int k)
        {
            // For this implementation, I re-inserted all values into the array,so there is overlap and execution is slow. Also there
            // should be no calculation of the average, only the sum of the elements. Because in the end all averages will be using
            // the same divisor (k) so the only thing that matters is the sum
            int[] result = new int[k];
            double highestAverage = double.MinValue;
            for(int i = 0; i < nums.Length; i++) 
            {
                if(i + k <= nums.Length)
                {
                    for (int j = 0; j < k; j++)
                    {
                        result[j] = nums[i + j];
                    }
                    if (result.Average() > highestAverage) highestAverage = result.Average();
                }
            }
            return highestAverage;
        }

        // The correct approach is to just subtract the first value, add the new last value, then calculate the avarage each time
        // This means that each value will only be accessed once ( time complexity will be O(N)), instead of k-1 times in my original

        public double FindMaxAverage(int[] nums, int k)
        {
            int maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                maxSum += nums[i];
            }
            int tempSum = maxSum;
            for (int i = k; i < nums.Length; i++)
            {
                tempSum += nums[i];
                tempSum -= nums[i - k];
                maxSum = Math.Max(tempSum, maxSum);
            }

            return ((double)maxSum / k);
        }
    }
}
