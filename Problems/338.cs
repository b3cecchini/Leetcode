using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode.Problems
{
    public class _338
    {
        public List<int> CountBits(int n)
        {
            int index = n;
            int counter = GetBits(n);
            
            List<int> bits = new() { n };
            
            while(counter > 0)
            {
               bits.Insert(0, n);
            }
            
            
            return bits;
        }

        private int GetBits(int n)
        {
            return (int)Math.Log(n, 2.0) + 1;
        }
    }
}
