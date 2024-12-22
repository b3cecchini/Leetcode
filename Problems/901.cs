using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _901
    {
        private List<int> prices;
        public void StockSpanner()
        {
            prices = new List<int>();
        }

        public int Next(int price)
        {
            prices.Add(price);

            int retval = 1 ;
            if (prices.Count != 0 && prices.LastOrDefault() <= price)
            {
                var last_index = prices.Count - 1;
                
                for(int i = last_index - 1; i >= 0; i--) 
                {
                    var prev = prices[i];
                    if(price >= prev) retval++;
                    if (price < prev) break; 
                }
                
            }
            return retval;
        }
    }
}
