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

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = head.next;
            ListNode temp;

            while (even.next.next != null)
            {
                temp = even.next; //next odd
                even.next = even.next.next; // next even
                odd.next = odd.next.next;
                
                odd = odd.next;
                even = even.next;
            }

            // at this point even.next is last odd

            even.next.next = evenHead;
            odd.next = even.next; 
            even.next = null;

            return odd;

        }
    }
}
