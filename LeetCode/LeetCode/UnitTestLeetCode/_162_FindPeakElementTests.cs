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
    public class _162_FindPeakElementTests
    {
        [TestMethod()]
        public void FindPeakElementTest()
        {
            int [] nums = { 1, 2, 3, 1 };
            int res = LeetCode._162_FindPeakElement.FindPeakElement(nums);
            Assert.AreEqual(2, res);

            int[] nums1 = { 1, 2, 3, 4, 5 };
            int res1 = LeetCode._162_FindPeakElement.FindPeakElement(nums1);
            Assert.AreEqual(4, res1);

            int[] nums2 = { 2, 1 };
            int res2 = LeetCode._162_FindPeakElement.FindPeakElement(nums2);
            Assert.AreEqual(0, res2);

            int[] nums3 = { 2 };
            int res3 = LeetCode._162_FindPeakElement.FindPeakElement(nums3);
            Assert.AreEqual(0, res3);
        }
    }
}
