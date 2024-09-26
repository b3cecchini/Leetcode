using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public  class _1456
    {

        public int MaxVowels(string s, int k)
        {

            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            string substr = s.Substring(0,k);

            int currentVowels = substr.Count(a => vowels.Contains(a)), maxCount = currentVowels;
            
            for(int i = k; i < s.Length; i++)
            {
                // instead of calculating the amount of vowels with str.Count(char => vowels.Contains((char)) just check if the incoming is
                // a vowel or if the one leaving the window is and adjust for each. Will only be gaining one and/ or losing one each time.
                if (vowels.Contains(s[i])) currentVowels++;

                if (vowels.Contains(s[i - k])) currentVowels--;

                maxCount = Math.Max(maxCount, currentVowels);
            }
            

            return maxCount;
            
        }

    }
}
