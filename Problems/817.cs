using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _817
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = 0;
            while (head.next!=null)
            {
                dict[head.val] = head.next.val;
                head = head.next;
            }

            foreach (int n in nums) count += (dict.ContainsKey(n) && nums.Contains(dict[n])) ? 1 : 0;
            
            return count;
        }
    }
}
