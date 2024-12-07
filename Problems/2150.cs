using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2150
    {
        public IList<int> FindLonely(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var ans = new List<int>();

            foreach (var x in nums)
            {
                if(dict.ContainsKey(x)) dict[x] = dict[x] + 1;
                else dict[x] = 1;
            }

           foreach (var y in dict.Keys)
            {
                if (dict[y] == 1 && !dict.ContainsKey(y - 1) && !dict.ContainsKey(y + 1)) ans.Add(y);
            }

            return ans;
        }
    }
}
