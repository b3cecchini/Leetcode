using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _75
    {
        public void SortColors(int[] nums)
        {
            int red = 0, white = 0, blue = 0;

            foreach (int i in nums)
            {
                if (i == 0) red++;
                else if (i == 1) white++;
                else blue++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(red > 0)
                {
                    nums[i] = 0;
                    red--;
                }
                else if(white > 0)
                {
                    nums[i] = 1;
                    white--;
                }
                else
                {
                    nums[i] = 2;
                    blue--;
                }
            }
        }
    }
}
