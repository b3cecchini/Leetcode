using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _1935
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {

            List<string> words = text.Split(' ').ToList();
            int ans = 0;
            bool flag = true;

            // text = "leet code", brokenLetters = "lt"
            foreach (string word in words)
            {
                // [ "leet", "code" ]
                foreach(char c in brokenLetters)
                {
                    // [ "l", "t" ]
                    if (word.Contains(c))
                    {
                        flag = false; 
                        break;
                    }
                }

                // if made it it though without encountering a broken letter, the word can be typed
                if (flag) ans++;

                // reset flag for next word
                flag = true;
            }

            return ans;
        }
    }
}
