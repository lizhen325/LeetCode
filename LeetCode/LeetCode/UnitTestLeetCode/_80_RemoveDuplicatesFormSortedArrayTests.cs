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
    public class _80_RemoveDuplicatesFormSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] nums = { 1, 1, 1, 2, 2, 2, 3 };
            int res = LeetCode._80_RemoveDuplicatesFormSortedArray.RemoveDuplicates(nums);
            Assert.AreEqual(5, res);

            int[] nums1 = { 1, 1, 1, 1 };
            int res1 = LeetCode._80_RemoveDuplicatesFormSortedArray.RemoveDuplicates(nums1);
            Assert.AreEqual(2, res1);

            int[] nums2 = { 1, 1, 1, 2 };
            int res2 = LeetCode._80_RemoveDuplicatesFormSortedArray.RemoveDuplicates(nums2);
            Assert.AreEqual(3, res2);
        }
    }
}
