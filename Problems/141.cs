using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _141
    {
        public bool HasCycle(ListNode head)
        {

            ListNode fast = head, slow = head;

            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;

        }
    }
}
