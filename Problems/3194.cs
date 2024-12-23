using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _3194
    {
        public double MinimumAverage(int[] nums)
        {
            List<double> averages = new List<double>();
            var numsList = nums.ToList();

            while(numsList.Count > 0)
            {
                var min = numsList.Min();
                var max = numsList.Max();

                numsList.Remove(min);
                numsList.Remove(max);


                averages.Add(((double)min + (double)max) / 2.0);
            }

            return (double)averages.Min();
        }
    }
}
