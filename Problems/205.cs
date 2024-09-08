using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Leetcode.Problems
{
    public class _205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if(s.Length != t.Length) return false;
            
            int[] map_s = new int[256];
            int[] map_t = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                char char_s = s[i];
                char char_t = t[i];

                if (map_s[char_s] != map_t[char_t])
                {
                    return false;
                }

                map_s[char_s] = i + 1;
                map_t[char_t] = i + 1;

            }

            return true;
           
        }
    }
}
