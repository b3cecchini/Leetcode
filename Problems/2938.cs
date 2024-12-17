using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2938
    {
        public long MinimumSteps(string s)
        {
            int l = 0;

            long t = 0;

            for (int i = l; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    t += (i - l);
                    l++;
                }
            }

            return t;
        }
    }
}
