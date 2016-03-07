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
    public class _81_SearchInRotatedSortedArrayIITests
    {
        [TestMethod()]
        public void SearchTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 4 };
            bool flag = LeetCode._81_SearchInRotatedSortedArrayII.Search(nums, 2);
            Assert.AreEqual(true, flag);

            int[] nums1 = { 1, 2, 3, 4, 5, 9 };
            bool flag1 = LeetCode._81_SearchInRotatedSortedArrayII.Search(nums1, 8);
            Assert.AreEqual(false, flag1);

            int[] nums2 = { 1 };
            bool flag2 = LeetCode._81_SearchInRotatedSortedArrayII.Search(nums2, 2);
            Assert.AreEqual(false,flag2);

            int[] nums3 = { 1, 1 };
            bool flag3 = LeetCode._81_SearchInRotatedSortedArrayII.Search(nums3, 2);
            Assert.AreEqual(false, flag3);
        }
    }
}
