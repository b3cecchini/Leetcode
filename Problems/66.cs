using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _66
    {
        public int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 10)
                {
                    if (i == 0)
                    {
                        Array.Resize(ref digits, digits.Length + 1);
                        digits[i] = 1;
                    }
                    else
                    {
                        digits[i - 1] = digits[i - 1] + 1;
                        digits[i] = 0;
                    }

                }
            }
            return digits;
        }
    }
}
