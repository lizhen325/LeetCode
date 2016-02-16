using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCLeetCode.Tests
{
    [TestClass]
    public class UnitTest122_Best_Time__to_Buy_and_Sell_Stock_II
    {
        [TestMethod]
        public void MaxProfitTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, -2, -5 };
            Best_Time__to_Buy_and_Sell_Stock_II b = new Best_Time__to_Buy_and_Sell_Stock_II();
            int profits = b.MaxProfit(arr);
            Assert.AreEqual(4, profits);
        }
    }
}
