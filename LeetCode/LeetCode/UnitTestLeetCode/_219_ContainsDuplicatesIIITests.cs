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
    public class _219_ContainsDuplicatesIIITests
    {
        [TestMethod()]
        public void ContainNearByDuplicateTest()
        {
            int[] nums = { 2, 3, 1, 4, 2 };
            bool res = LeetCode._219_ContainsDuplicatesIII.ContainNearByDuplicate(nums, 4);
            Assert.IsTrue(res);
        }
    }
}
