using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1957
    {
        /*
         *  
         *  Input: s = "leeetcode"
            Output: "leetcode"
            Explanation:
            Remove an 'e' from the first group of 'e's to create "leetcode".
            No three consecutive characters are equal, so return "leetcode".
            
            Input: s = "aaabaaaa"
            Output: "aabaa"
            Explanation:
            Remove an 'a' from the first group of 'a's to create "aabaaaa".
            Remove two 'a's from the second group of 'a's to create "aabaa".
            No three consecutive characters are equal, so return "aabaa".
         */
        public string MakeFancyString_first(string s)
        {
            // This implementation works but is slow and uses lots of mem, execution timeout when submitting answer 
            for (int i = 0; i < s.Length - 2; i++)
            {

                if (s[i] == s[i+1] && s[i] == s[i+2])
                {
                    s = s.Substring(0, i) + s.Substring(i + 1);
                    i--;
                }
            }
            return s;

        }

        public string MakeFancyString(string s)
        {
            /*
             * ffffffiiiiiiiiiigggggggggggggssssssskkkkkkkkkkkzzzzzzzzzzzzzzzzzgggggggyyyyyy
             */
            int counter = 0;
            string answer = s[0].ToString();
            for (int i = 1; i < s.Length; i++)
            {
                answer += s[i];
                while ((i + counter < s.Length - 2) && s[i + counter] == s[i + counter + 1] && s[i] == s[i + counter + 2])
                {
                    counter++;
                }
                
                i = i + counter;
                counter = 0;
            }
            return answer;

        }
    }
}
