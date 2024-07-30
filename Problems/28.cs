using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _28
    {
        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            int loopCounter = 0;
            while (haystack.Length >= needle.Length)
            {
                try
                {
                    index = haystack.IndexOf(needle[0]);
                    if (haystack.Substring(index, needle.Length) == needle)
                    {
                        return index + loopCounter;
                    }
                    else
                    {
                        loopCounter += 1;
                        haystack = haystack.Substring(1);
                    }
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
    }
}
