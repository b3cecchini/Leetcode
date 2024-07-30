using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    internal class _50
    {
        // Easy way out
        public double MyPow(double x, int n)
        {
            return Math.Pow(x, n);
        }




        // Solution I was aiming for
        public double MyPow_Solution(double x, int n)
        {
            double ans = 0;
            if (x == 0)
            {
                return 0;
            }
            if (n > 0)
            {
                if (n >= 2)
                {
                    if (n % 2 == 0)
                    {
                        double temp = MyPow(x, n / 2);
                        ans = temp * temp;
                    }
                    else
                    {
                        double temp = MyPow(x, n / 2);
                        ans = temp * temp * x;
                    }
                }
                else if (n == 1)
                {
                    return x;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (n <= -2)
                {
                    if (n % 2 == 0)
                    {
                        double temp = MyPow(x, n / 2);
                        ans = temp * temp;
                    }
                    else
                    {
                        double temp = MyPow(x, n / 2);
                        ans = temp * temp * 1 / x;
                    }
                }
                else if (n == -1)
                {
                    return 1 / x;
                }
                else
                {
                    return 1;
                }
            }
            return ans;
        }
    }
}
