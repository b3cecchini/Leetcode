using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    internal class _128
    {
        public int LongestConsecutive(int[] nums)
        {
            SortedSet<int> numberSet = new SortedSet<int>(nums);

            int start = numberSet.Min;
            int length = 0;
            int bestLength = 0;
            int current = 0;
            int previous = 0;
            foreach (var num in numberSet)
            {
                if (num != start)
                {

                    current = num;
                    if (current == (previous + 1))
                    {
                        length++;
                    }
                    else
                    {
                        if (length >= bestLength)
                        {
                            bestLength = length;
                        }
                        length = 1;
                    }
                }
                else
                {
                    length++;
                }

                previous = num;
            }

            if (length > bestLength)
            {
                bestLength = length;
            }

            return bestLength;

        }
    }
}
