using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2942
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            IList retval = new List<int>();
            for(int i  = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x)) retval.Add(i);
            }
            return (IList<int>)retval;
            
            
        }
    }
}
