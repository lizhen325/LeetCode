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
    public class _16_3SumClosetTests
    {
        [TestMethod()]
        public void ThreeSumClosestTest()
        {
            int[] nums1 = { -1, 2, 1, 4 };
            int res1 = LeetCode._16_3SumCloset.ThreeSumClosest(nums1, 1);
            Assert.AreEqual(2, res1);

            int[] nums2 = { 0, 0, 0 };
            int res2 = LeetCode._16_3SumCloset.ThreeSumClosest(nums2, 1);
            Assert.AreEqual(0, res2);
        }
    }
}
