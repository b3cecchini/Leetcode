using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _229
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int control = nums.Length / 3;
            List<int> ans = new List<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;
            }

            foreach(var s in dict)
            {
                if(s.Value > control) ans.Add(s.Key);
            }

            return ans;

        }
    }
}
