using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2374
    {
        public int EdgeScore(int[] edges)
        {
            Dictionary<int, double> dict = new Dictionary<int, double>();

            for (int i = 0; i < edges.Length; i++)
            {
                if (dict.ContainsKey(edges[i])) dict[edges[i]]+= i;
                else dict[edges[i]] = i;
            }

            var best = (0, (double)0);

            foreach(var keyval in dict)
            {
                if (keyval.Value > best.Item2 || (keyval.Value == best.Item2 && keyval.Key < best.Item1)) best = (keyval.Key, keyval.Value); 
            }

           return best.Item1;
        }

    }
}
