using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _507
    {
        public bool CheckPerfectNumber(int num)
        {
            int sum = 0;
            int divisor = 2;
            HashSet<int> set = new HashSet<int>();
            
            while (divisor < num / 2)
            {   
                if(num % divisor == 0)
                {
                    if(!set.Contains(divisor)) set.Add(divisor);
                    if (!set.Contains(num / divisor)) set.Add(num / divisor);
                }
                divisor++;
            }
            set.Add(1);
            foreach (int i in set)
            {
                sum += i;
            }

            return sum == num;
        }
    }
}
