using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _278
    {
        public int FirstBadVersion(int n)
        {
            int low =0, bad =1, high=n;

            while (low <= high)
            {
                var mid = low + ((high - low) / 2);

                if (isBadVersion(mid))
                {
                    bad = mid;
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }

            }

            return bad;

        }
        private bool isBadVersion(int val)
        {
            if (val < 4) return false;
            return true;
        }
    }

   
}
