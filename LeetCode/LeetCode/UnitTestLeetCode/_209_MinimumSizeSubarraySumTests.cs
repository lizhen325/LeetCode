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
    public class _209_MinimumSizeSubarraySumTests
    {
        [TestMethod()]
        public void MinSubArrayLenTest()
        {
            int[] nums1 = { 2, 3, 1, 2, 4, 3 };
            int count1 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(7, nums1);
            Assert.AreEqual(2, count1);

            int[] nums2 = { 1, 2, 3, 4, 5 };
            int count2 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(11, nums2);
            Assert.AreEqual(3, count2);

            int[] nums3 = { 10, 2, 3 };
            int count3 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(6, nums3);
            Assert.AreEqual(1, count3);

            int[] nums4 = { };
            int count4 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(100, nums4);
            Assert.AreEqual(0, count4);

            int[] nums5 = { 2, 16, 14, 15 };
            int count5 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(20, nums5);
            Assert.AreEqual(2, count5);

            int[] nums6 = { 1, 1 };
            int count6 = LeetCode._209_MinimumSizeSubarraySum.MinSubArrayLen(3, nums6);
            Assert.AreEqual(0, count6);
        }
    }
}
