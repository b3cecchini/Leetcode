using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _1684
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;
            char[] allowedList = allowed.ToCharArray();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowedList.Contains(words[i][j])) break;
                    else if (j == words[i].Length - 1) count++;
                }
            }

            return count;
        }
    }
}
