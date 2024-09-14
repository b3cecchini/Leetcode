using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _150
    {
        public int EvalRPN(string[] tokens)
        {
            string[] result = tokens;

            int opIndex;
            int newVal;
            while (result.Length > 1)
            {
                opIndex = FindFirstOp(result);

                newVal = Evaluate(Int32.Parse(result[opIndex - 2]), Int32.Parse(result[opIndex - 1]), result[opIndex]);

                result = DeleteAndReplaceInArray(result, opIndex, newVal.ToString());
            }

            return Int32.Parse(result.FirstOrDefault());
        }

        public string[] DeleteAndReplaceInArray(string[] array, int index, string newValue)
        {
            if (index < 2 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be at least 2 and less than the array length.");
            }

            string[] newArray = new string[array.Length - 2];
            Array.Copy(array, 0, newArray, 0, index - 2);
            newArray[index - 2] = newValue;

            if (index < array.Length - 1)
            {
                Array.Copy(array, index + 1, newArray, index - 1, array.Length - index - 1);
            }

            return newArray;
        }

        private int FindFirstOp(string[] tokens)
        {
            var retval = 0;
            int outNum;
            for (int i = 0; i < tokens.Length; i++)
            {
                if(!Int32.TryParse(tokens[i], out outNum))
                {
                    return i;
                }
            }
            return retval;
        }

        private int Evaluate(int prevTotal, int value, string op)
        {
            if (op == "*")
            {
                return prevTotal * value;
            }
            else if (op == "+")
            {
                return prevTotal + value;
            }
            else if (op == "-")
            {
                return prevTotal - value;
            }
            else 
            {
                return prevTotal / value; 
            }
        }
    }
}
