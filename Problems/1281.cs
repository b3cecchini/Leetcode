using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1281
    {
        public int SubtractProductAndSum(int n)
        {
            // Parse as string to get digits
            var str = n.ToString();
            int prod = 1;
            int sum = 0;

            // Loop through digits, calculate product and sum (can probabably do in parallel)
            foreach (char d in str)
            {
                var digit = Int32.Parse(d.ToString());
                prod *= digit;
                sum += digit;
            }


            // return prod - sum
            return prod - sum;
        }
    }
}
