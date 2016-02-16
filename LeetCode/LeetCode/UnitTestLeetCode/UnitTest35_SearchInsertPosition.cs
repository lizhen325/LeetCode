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
    public class UnitTest35_SearchInsertPosition
    {
        [TestMethod()]
        public void SearchInsertPosition()
        {
            int[] nums = { 1, 3, 5, 6 };
            int position = _35.SearchInsert(nums, 0);
            Assert.AreEqual(0, position);
        }
    }
}
