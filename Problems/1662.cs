using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Concat(word1) == string.Concat(word2);
        }
    }
}
