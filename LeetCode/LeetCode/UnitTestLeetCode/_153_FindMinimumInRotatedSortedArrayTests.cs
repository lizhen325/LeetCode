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
    public class _153_FindMinimumInRotatedSortedArrayTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = {4,5,6,7,0,1,2,3 };
            int res = LeetCode._153_FindMinimumInRotatedSortedArray.FindMin(nums);
            Assert.AreEqual(0,res);
        }
    }
}
