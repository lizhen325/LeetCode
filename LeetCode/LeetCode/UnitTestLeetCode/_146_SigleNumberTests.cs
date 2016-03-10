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
    public class _136_SigleNumberTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            int[] nums1 = { 1, 2, 3, 4, 1,2,4 };
            int res1 = LeetCode._136_SigleNumber.SingleNumber(nums1);
            Assert.AreEqual(3, res1);
        }
    }
}
