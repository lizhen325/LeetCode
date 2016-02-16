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
    public class UnitTest268MissingNumber
    {
        [TestMethod()]
        public void MissingNumber()
        {
            int[] nums = { 0, 1, 3 };
            int missingNumber = _268.MissingNumber(nums);
            Assert.AreEqual(2, missingNumber);

            int[] res = { 0 };
            int ms = _268.MissingNumber(res);
            Assert.AreEqual(1, ms);

            int[] res2 = { 1 };
            int ms2 = _268.MissingNumber(res2);
            Assert.AreEqual(0, ms2);
        }
    }
}
