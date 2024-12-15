using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _290
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string[] sArr = s.Split(' ');

            if (sArr.Length != pattern.Length) return false;

            for (int i =0;  i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != sArr[i]) return false;
                }
                else if (dict.ContainsValue(sArr[i])) return false;
                else dict.Add(pattern[i], sArr[i]);
            }

            return true;
        }
    }
}
