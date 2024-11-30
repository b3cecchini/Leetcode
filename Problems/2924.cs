using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2924
    {
        public int FindChampion(int n, int[][] edges)
        {
            HashSet<int> losers = new HashSet<int>();
            for(int i = 0; i < edges.Length; i++)
            {
                if(!losers.Contains(edges[i][1]))
                {
                    losers.Add(edges[i][1]);
                }
            }

            HashSet<int> winners = new HashSet<int>();

            for (int i = 0;i < n; i++)
            {
                if (!losers.Contains(i))
                {
                    winners.Add(i);
                }
            }

            if (winners.Count == 1) 
            {
                return winners.FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }
    }
}
