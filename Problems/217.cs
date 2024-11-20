using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (int num in nums)
            {
                if (result.Contains(num)) return true;
                else result.Add(num);
            }
            return false;
        }
    }
}
