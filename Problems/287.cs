using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _287
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (int i in nums)
            {
                if (result.Contains(i)) return i;
                result.Add(i);
            }

            return 0;
        }
    }
}
