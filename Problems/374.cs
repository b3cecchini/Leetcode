using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _374
    {
        private NumberGuess _numberGuess = new ();
        int min = 1;
        int max = Int32.MaxValue;
        int cur;
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            /*
            while (left <= right) 
            {
                int mid = left +(right-  left) / 2;

                int guess = _numberGuess.guess(mid);

                if(guess == 0) return mid;
                else if(guess == -1) right = mid - 1;
                else if(guess == 1) left = mid + 1;
            }*/

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = _numberGuess.guess(mid);

                if (result == 0)
                {
                    return mid;
                }
                else if (result == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return 0;
        }


        public int GuessNumber_2(int n)
        {
            
            if(_numberGuess.guess(min) == 0) return n;
            if(_numberGuess.guess(max) == -1) return n;

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
