using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode node = new ListNode();
            node.next = head;

            ListNode curr = node;
            ListNode fast = node;

            for (int i = 0; i <= n; i++) 
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                curr = curr.next;
            }

            // at this point fast is at the end and curr is 'n' from the back

            curr.next = curr.next.next;
            return node.next;
            
        }

    }
}
