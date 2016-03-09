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
    public class _1_TwoSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] res1 = LeetCode._1_TwoSum.TwoSum(nums1,9);
            CollectionAssert.AreEqual(new int[]{0,1},res1);

            int[] nums2 = { 3, 2, 4 };
            int[] res2 = LeetCode._1_TwoSum.TwoSum(nums2, 6);
            CollectionAssert.AreEqual(new int[] { 1, 2 }, res2);
        }
    }
}
