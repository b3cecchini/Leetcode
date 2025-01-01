using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _382
    {
        private ListNode head;
        private int l;
        private Random random;
        public _382(ListNode head)
        {
            this.head = head;
            var temp = head;
            while(temp != null)
            {
                temp = temp.next;
                this.l++;
            }
            this.random = new Random();
        }

        public int GetRandom()
        {
            int count = random.Next(0, l);
            var node = this.head;
            for(int i =0; i <= count; i++ ) { node = node.next; }
            return node.val;
        }
    }
}
