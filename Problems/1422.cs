using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1422
    {
        public int MaxScore_2(string s)
        {
            int best = 0;
            int r = s.Count(s => s == '1');

            int l = 0;
            for(int i = 0; i < s.Length -1 ; i++)
            {
                if (s[i] == '0') l++;
                else r--;

                best = Math.Max(best, l + r);
            }
            return best;
        }
        public int MaxScore_1(string s)
        {
            int best = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int l = 0, r = 0;
                for(int j = 0; j <=i && j < s.Length - 1; j++) if (s[j] == '0') l++;
                for(int k = i+1;  k < s.Length; k++) if (s[k] == '1') r++;
                
                best = Math.Max(best, l+r);
            }
            return best;
        }
    }
}
