using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            string result = "";

            int counter = 0;

            while(word1.Length > 0 || word2.Length > 0 )
            {
                if(counter % 2 == 0 && word1.Length > 0)
                {
                    result += word1[0];
                    word1 = word1.Substring(1);
                }
                else if(word2.Length > 0)
                {
                    result += word2[0];
                    word2 = word2.Substring(1);
                }
                counter++;
            }

            return result;

        }
    }
}
