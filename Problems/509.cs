using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _509
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public int Fib(int n)
        {
            if(n == 0) return 0;
            else if(n == 1) return 1;
            else return Fib(n - 1) + Fib(n - 2);
        }
    }
}

