using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LeetCode.Tests
{
    [TestClass()]
    public class _299_BullsAndCowsTests
    {
        [TestMethod()]
        public void GetHintTest()
        {
            string secret = "1807";
            string guess = "7810";
            string res = LeetCode._299_BullsAndCows.GetHint(secret, guess);
            Assert.AreEqual("1A3B", res);
        }
    }
}
