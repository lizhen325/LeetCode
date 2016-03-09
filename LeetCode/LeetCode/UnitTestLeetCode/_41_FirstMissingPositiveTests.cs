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
    public class _41_FirstMissingPositiveTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            int[] nums1 = { 5, 4, -1,1,3 };
            int res1 = LeetCode._41_FirstMissingPositive.FirstMissingPositive(nums1);
            Assert.AreEqual(2, res1);

            int[] nums2 = { 1, 2, 0 };
            int res2 = LeetCode._41_FirstMissingPositive.FirstMissingPositive(nums2);
            Assert.AreEqual(1, res2);
        }
    }
}
