using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode.Problems
{
    public class _3233
    {
        public int NonSpecialCount(int l, int r)
        {
            if (r == 1) return 1;

            if (r == 2) return l == 1 ? 2 : 1;

            if (r == 3) return l == 1 ? 3 : l == 2 ? 2 : 1;
            int count = 0;
            for (int i = (int)Math.Sqrt(l); i <= (int)Math.Sqrt(r); i++)
            {
                if (isSpecial(i) && i * i >= l && i * i <= r) count++;
            }

            return (r - l + 1) - count;

        }


        private System.Boolean isSpecial(int number)
        {
            if (number <= 1) return false;

            if (number == 2 || number == 3) return true;

            for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
            {
                if (number % i == 0)return false;
            }

            return true;
        }
    }
}
