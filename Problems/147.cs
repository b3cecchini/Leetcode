using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _147
    {
        public ListNode InsertionSortList(ListNode head)
        {
            List<int> vals = new List<int>();
            ListNode ptr = head;
            while (ptr != null)
            {
                vals.Add(ptr.val);
                ptr = ptr.next;
            }
            vals.Sort();
            ListNode ans = new ListNode(vals[0]);
            ListNode curr = ans;
            for (int i = 1; i < vals.Count; i++)
            {
                curr.next = new ListNode(vals[i]);
                curr = curr.next;
            }

            return ans;


        }
    }
}
