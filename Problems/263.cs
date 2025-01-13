using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _263
    {
        public bool IsUgly(int n)
        {
            if( n < 1 ) return false;   
            List<int> factors = new List<int>();

            while (n % 2 == 0) { factors.Add(2); n /= 2; }

            for (int i = 3; i * i <= n; i += 2) while (n % i == 0) { factors.Add(i); n /= i; }

            if (n > 2)
            {
                factors.Add(n);
            }

            return !factors.Where(i => i != 2 && i != 3 && i != 5).ToList().Any();
            
        }
    }
}
