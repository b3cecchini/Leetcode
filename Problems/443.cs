using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _443
    {
        // ["a","a","b","b","c","c","c"]
        // 6 "a2b2c3"
        public int Compress(char[] chars)
        {
            string answer = "";
            int counter;
            char curr;
            int i = 0;
            while (i < chars.Length) 
            {
                curr = chars[i];

                counter = 0;
                while ((i+counter+1 <chars.Length) && chars[i+counter] == chars[i+counter + 1])
                {
                    counter++;
                }

                i += counter + 1;

                while (counter >= 9)
                {
                    answer += curr + "9";
                    counter -= 9;
                }

                answer += curr + ((counter + 1).ToString());   
            }


            return answer.Length;
        }
    }
}
