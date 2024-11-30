using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _1446
    {
        public int MaxPower(string s)
        {
           
            int best = 0;
            int i = 0;
            if (s.Length < 2) return s.Length;
            while (i < s.Length - 1)
            {
                char c = s[i];
                int temp = i+1;
                
                while (temp < s.Length && s[temp] == c)
                {
                    temp++;
                }
                best = Math.Max(best, temp - i);
                i = temp;
            }
            
            return best;
        }
    }
}
