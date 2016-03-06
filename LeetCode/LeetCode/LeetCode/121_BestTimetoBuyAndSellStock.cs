using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _121_BestTimetoBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;
            int low = prices[0];
            int max = 0;
            for(int i = 1; i<prices.Length; i++)
            {
                if (prices[i] < low)
                    low = prices[i];
                else if (prices[i] - low > max)
                    max = prices[i] - low;
            }
            return max;
        }
    }
}
