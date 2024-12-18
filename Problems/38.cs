using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _38
    {
        public string CountAndSay(int n)
        {
            var retval = "1";
            if (n == 1) return retval ;

            for (int i = 1; i < n; i++)
            {
                retval = Group(retval);
            }

            return retval;
        }

        public string Group(string s)
        {
            List<(int, char)> result = new();
            int fast = 1;
            int i = 0;
            if (s.Length == 1)
            {
                result.Add((fast, s[0]));
            }
            else
            {
                while (i < s.Length - 1)
                {
                    var c = s[i];
                    while ((i + fast < s.Length - 1) && s[i + fast] == c) fast++;

                    result.Add((fast, c));
                    i = i + fast;
                    fast = 1;
                }

                var lastChar = s[s.Length - 1];
                if (lastChar == result.Last().Item2)
                {
                    var val = result.Last();
                    var newVal = (val.Item1 + 1, val.Item2);
                    result[result.Count - 1] = newVal;
                }
                else
                {
                    result.Add((1, lastChar));
                }
            }


            StringBuilder sb = new StringBuilder();
            foreach (var value in result)
            {
                sb.Append(value.Item1);
                sb.Append(value.Item2.ToString());
            }



            return sb.ToString();
        }
    }
}
