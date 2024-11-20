using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _392
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int cur = 0;

            foreach(char c in s) 
            {
                bool found = false;
                for(i = cur; !found && i < t.Length; i++)
                {
                    if (t[i] == c)
                    {
                        found = true;
                        cur = i++;
                    }
                }
                if (!found) { return false; }
            }

            return true;
        }

    }
}
