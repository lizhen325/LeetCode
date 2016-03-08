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
    public class _34_SearchForARangeTests
    {
        [TestMethod()]
        public void SearchRangeTest()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int[] res = LeetCode._34_SearchForARange.SearchRange(nums, 8);
            CollectionAssert.AreEqual(new int[] { 3, 4 }, res);

            int[] nums1 = { 1 };
            int[] res1 = LeetCode._34_SearchForARange.SearchRange(nums1, 1);
            CollectionAssert.AreEqual(new int[] { 0,0 }, res1);

            int[] nums2 = { 2, 2 };
            int[] res2 = LeetCode._34_SearchForARange.SearchRange(nums2, 3);
            CollectionAssert.AreEqual(new int[] { -1, -1 }, res2);

            int[] nums3 = { 2, 2 };
            int[] res3 = LeetCode._34_SearchForARange.SearchRange(nums3, 2);
            CollectionAssert.AreEqual(new int[] { 0, 1 }, res3);

        }
    }
}
