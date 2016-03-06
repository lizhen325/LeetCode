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
    public class _26_RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] nums = { 1, 1, 2 };
            int count = LeetCode._26_RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);
            Assert.AreEqual(2, count);
        }
    }
}
