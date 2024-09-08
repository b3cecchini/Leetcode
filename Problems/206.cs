using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode next = null;
            ListNode curr = head;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
