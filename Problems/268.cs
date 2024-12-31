using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _268
    {
        public int MissingNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(!nums.Contains(i)) return i;
            }
            return 0;
        }
    }
}
