using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _345
    {
        public string ReverseVowels(string s)
        {
            char[] chars = s.ToCharArray();

            char[] vowels = ['A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'];

            int i = 0, j = s.Length - 1;

            bool foundLeft = false, foundRight = false;

            while (i < j)
            {
                if (vowels.Contains(s[i]))
                {
                    foundLeft = true;
                }
                else
                {
                    i++;
                }
                if (vowels.Contains(s[j]))
                {
                   foundRight = true;
                }
                else
                {
                    j--;
                }
                if(foundLeft && foundRight)
                {
                    var leftswap = s[i];
                    var rightswap = s[j];
                    chars[i] = rightswap;
                    chars[j] = leftswap;
                    foundLeft = false;
                    foundRight = false;
                    i++;
                    j--;
                }
            }

            return string.Concat(chars);
        }
    }
}
