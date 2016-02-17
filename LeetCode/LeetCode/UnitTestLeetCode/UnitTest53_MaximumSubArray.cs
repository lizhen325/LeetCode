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
    public class UnitTest53_MaximumSubArray
    {
        [TestMethod()]
        public void MaximumSubArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maximum = MaximumSubarray.MaxSubArray(nums);
            Assert.AreEqual(6, maximum);
        }
    }
}
