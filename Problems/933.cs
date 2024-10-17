using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _933
    {
        Queue<int> q;
        public _933()
        {
            q = new Queue<int>();
        }

        public int Ping(int t)
        {
            q.Enqueue(t);

            return q.Count(a => a >= t - 3000);
        }
    }
}
