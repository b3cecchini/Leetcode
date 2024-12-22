using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _912
    {
        private List<int> retval = new List<int>();

        public int[] SortArray(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Insert(nums[i]);
            }

            return retval.ToArray();
        }

        public void Insert(int num)
        {
            int left = 0;
            int right = retval.Count - 1;

            while (left < right)
            {
                var mid = (left + right) / 2;
                if (retval[mid] == num || 
                    (retval[mid] > num && retval[mid - 1] < num) ||
                    (retval[mid] < num && retval[mid + 1] > num))
                {
                    retval.Insert(mid, num);
                }
                else if (retval[mid] > num)
                {
                    right = mid - 1;
                }
                else if(retval[mid] < num)
                {
                    left = mid + 1;
                }
            }
            
        }
    }
}
