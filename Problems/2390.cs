using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2390
    {
        public string RemoveStars(string s)
        {
            Stack<char> st = new Stack<char>();

            foreach (char c in s)
            {
                if (c != '*') 
                {
                    st.Push(c);
                }
                else
                {
                    st.Pop();
                }
            }

            char[] ch_result = st.ToArray();
            Array.Reverse(ch_result);

            return string.Join("", ch_result);
        }
    }
}
