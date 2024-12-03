using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _398
    {

        private static Random rand = new Random();
        private List<int> list = new List<int>();

        public _398(int[] nums) 
        {
            foreach (int i in nums)
            {
                list.Add(i);
            }
        }


        public int Pick(int target)
        {
            var hits = new List<int>();

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == target) hits.Add(i);
            }
            
            if(hits.Count > 0)
            {
                int index = rand.Next(0, hits.Count);
                return hits[index];
            }
            else
            {
                return 0;
            }
            
        }
    }
}
