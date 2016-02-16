using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Best_Time__to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            int profits = 0;
            for (int i = 1; i < prices.Length; i++ )
            {
                int diff = prices[i] - prices[i - 1];
                if(diff > 0)
                {
                    profits += diff;
                }
            }
                return profits;
        }
    }
}
