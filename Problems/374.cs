using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    internal class _374
    {
        private NumberGuess _numberGuess = new ();
        public int GuessNumber(int n)
        {
            int min = 1;
            int max = Int32.MaxValue;
            int target = min;
            while (true)
            {
                Console.WriteLine("==================================");
               
                int minGuess = _numberGuess.guess(min); // -1
                int maxGuess = _numberGuess.guess(max); // 1
                Console.WriteLine($"min: {min} max: {max} minGuess: {minGuess} maxGuess: {maxGuess}");
                if (minGuess == 0)
                {
                    return min;
                }
                else if (maxGuess == 0)
                {
                    return max;
                }
                else
                {
                    //Console.WriteLine($"maxGuess / 2 : {_numberGuess.guess(max / 2)}");
                    if(_numberGuess.guess(max / 2) == 1 && _numberGuess.guess(min * 2) == -1)
                    {
                        min++;
                        continue;
                    }
                    switch (_numberGuess.guess(max / 2))
                    {
                        case 1:
                            max = max / 2;
                            break;
                        case -1:
                            min = min * 2;
                            break;
                        default:
                            break;
                    }
                }
               
            }
            return 0;
        }
    }
}
