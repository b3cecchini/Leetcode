using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _17
    {

        Dictionary<int, char[]> dict = new Dictionary<int, char[]>()
        {
            [2] = ['a', 'b', 'c'],
            [3] = ['d', 'e', 'f'],
            [4] = ['g', 'h', 'i'],
            [5] = ['j', 'k', 'l'],
            [6] = ['m', 'n', 'o'],
            [7] = ['p', 'q', 'r', 's'],
            [8] = ['t', 'u', 'v'],
            [9] = ['w', 'x', 'y', 'z']
        };


        public IList<string> LetterCombinations(string digits)
        {
            var ans = new List<string>();
            HashSet<char> comb = new HashSet<char>();
            foreach (char c in digits)
            {
                comb.Add(c);
                foreach (char x in dict[c])
                {
                    comb.Add(x);
                   
                }
            }
            return ans;
        }
    }
}
