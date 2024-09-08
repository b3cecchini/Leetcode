using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _202
    {
        public bool IsHappy(int n)
        {
            if (n == 1) return true;
            int slowPointer = n;
            int fastPointer = GetSum(n);
            while (slowPointer != fastPointer)
            {
                if (slowPointer == 1 || fastPointer == 1)
                {
                    return true;
                }
                slowPointer = GetSum(slowPointer);
                fastPointer = GetSum(GetSum(fastPointer));
            }
            return false;
        }

        private int GetSum(int number)
        {

            string numberString = number.ToString();
            int sum = 0;

            foreach (char digit in numberString)
            {
                int numericValue = int.Parse(digit.ToString());
                sum += numericValue * numericValue;
            }

            return sum;
        }
    }
}
