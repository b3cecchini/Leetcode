using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _328
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            if(head.next == null || head.next.next == null) return head;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = head.next;
            ListNode oddHead = head;

            while (even.next.next != null)
            {
                odd.next = odd.next.next;
                even.next = even.next.next; 
                
                odd = odd.next;
                even = even.next;
                if (even.next == null) break;
            }

            // at this point even.next is last odd
            if(even.next == null)
            {
                even.next = evenHead;
            }
            else
            {
                even.next.next = evenHead;
                
            }

            odd.next = even.next;
            even.next = null;
            return oddHead;

        }
    }
}
