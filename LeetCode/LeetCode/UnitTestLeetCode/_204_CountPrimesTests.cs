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
    public class _204_CountPrimesTests
    {
        [TestMethod()]
        public void CountPrimesTest()
        {
            int n = 5;
            int res = LeetCode._204_CountPrimes.CountPrimes(n);
            Assert.AreEqual(2, res);
        }
    }
}
