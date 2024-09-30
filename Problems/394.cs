using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _394
    {
        
        public string DecodeString(string s)
        {
            int pointer = 0;
            Stack<string> stack = new Stack<string>();

            while (pointer < s.Length)
            {
                if (char.IsDigit(s[pointer]))
                {
                    //find the rest of the number
                    string num_as_str = "";
                    while(char.IsDigit(s[pointer]))
                    {
                        num_as_str += s[pointer];
                        pointer++;
                    }
                    stack.Push(num_as_str);
                }
                else if (s[pointer] == ']')
                {
                    // take care of "[" and "["
                    string inner_string = "";
                    while (stack.Peek() != "[")
                    {
                        inner_string += stack.Pop() + inner_string;
                    }
                    stack.Pop();
                    int number = int.Parse(stack.Pop());
                    inner_string = string.Concat(Enumerable.Repeat(inner_string, number));
                    stack.Push(inner_string);
                    pointer++;

                }
                else
                {
                    stack.Push(s[pointer].ToString());
                    pointer++;
                }
            }

            string decoded = "";
            while (stack.Count > 0)
            {
                decoded = stack.Pop() + decoded;
            }

            return decoded;

        }
    }
}
