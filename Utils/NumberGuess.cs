using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Utils
{
    public class NumberGuess
    {
        private int number = 6;

        public int guess(int n)
        { 
            return  n < number ? -1 : n > number ? 1 : 0; 
        }
    }
}
