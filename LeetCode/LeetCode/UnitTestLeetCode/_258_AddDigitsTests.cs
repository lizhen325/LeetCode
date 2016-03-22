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
    public class _258_AddDigitsTests
    {
        [TestMethod()]
        public void AddDigitsTest()
        {
            int num = 38;
            int res = LeetCode._258_AddDigits.AddDigits(num);
            Assert.AreEqual(2, res);
        }
    }
}
