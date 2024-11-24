using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _387
    {
        public int FirstUniqChar(string s)
        {
            List<char> chars = new List<char>();
            HashSet<char> seen = new HashSet<char>();

            // "aadadaad"

            // c    "d"
            // chars  []
            // seen   ["a"]

            foreach (char c in s)
            {
                if (!seen.Contains(c))
                {
                    if (chars.Contains(c))
                    {
                        chars.Remove(c);
                        seen.Add(c);
                    }
                    else
                    {
                        chars.Add(c);
                    }
                }
            }

            var targetChar = chars.FirstOrDefault();
            return s.IndexOf(targetChar);
        }
    }
}
