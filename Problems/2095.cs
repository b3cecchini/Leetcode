using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _2095
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null) return null;
            
            ListNode s = head;
            ListNode f = head.next;
            int count = 1;
            while (f.next != null)
            {
                f = f.next;
                if (count % 2 == 0) s = s.next;
                count++;
            }

            s.next = s.next.next;
            
            return head;
        }
    }
}
