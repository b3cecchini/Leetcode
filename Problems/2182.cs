using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2182
    {
       
        public string RepeatLimitedString(string s, int repeatLimit)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s) dict[c] = dict.GetValueOrDefault(c, 0) + 1;
            
            StringBuilder sb = new StringBuilder();

            var keys = dict.Select(i => i.Key).OrderByDescending(i => i).ToList();

            int count = 0;
            int next = 1;
            while(count < keys.Count)  
            {
                var c = keys[count];
                for (int i = 0; i < repeatLimit && dict[c] > 0; i++) 
                {
                    sb.Append(c);
                    dict[c] -= 1;
                }

                if (count == next) next++;

                if (dict[c] > 0)
                {
                    if (next >= keys.Count) break;

                    var nextChar = keys[next];
                    sb.Append(nextChar);
                    dict[nextChar]--;

                    if (dict[nextChar] == 0) next += 1;

                    continue;
                }

                count++;

            }
            return sb.ToString();
        }
    }
}
