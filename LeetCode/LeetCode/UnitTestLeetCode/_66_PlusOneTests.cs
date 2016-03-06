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
    public class _66_PlusOneTests
    {
        [TestMethod()]
        public void PlusOneTest()
        {
            int[] nums = { 8, 9 };
            int[] res = LeetCode._66_PlusOne.PlusOne(nums);           
            CollectionAssert.AreEqual(new int[] {9,0},res);

            int [] nums1 = { 9, 9 };
            int[] res1 = LeetCode._66_PlusOne.PlusOne(nums1);
            CollectionAssert.AreEqual(new int[] { 1, 0, 0 }, res1);
        }
    }
}
