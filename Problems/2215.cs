using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<IList<int>> result = [new List<int>(), new List<int>()];

            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            foreach (int i in set2)
            {
                if(!set1.Contains(i)) result[1].Add(i);
            }
            foreach (var value in set1)
            {
                if(!set2.Contains(value)) result[0].Add(value);
            }

            return result;
        }
    }
}
