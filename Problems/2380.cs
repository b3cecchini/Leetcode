using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2380
    {
        public int SecondsToRemoveOccurrences(string s)
        {
            int counter = 0;
            while (s.Contains("01"))
            {
                s = s.Replace("01", "10");
                counter++;
            }
            return counter;

        }
    }
}
