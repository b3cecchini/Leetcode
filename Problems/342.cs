using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _342
    {
        public bool IsPowerOfFour(int n)
        {
            if (n == 1) return true;
            if (n < 4) return false;
            
            return (n % 4 == 0 && IsPowerOfFour(n / 4));
        }
    }
}
