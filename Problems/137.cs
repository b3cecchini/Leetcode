using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _137
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    map[num] = 0;
                }
                map[num]++;
            }

            foreach (var key in map)
            {
                if (key.Value == 1) return key.Key;
            }

            return 0;
        }
    }
}
