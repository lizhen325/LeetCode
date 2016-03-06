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
    public class _27_Remove_ElementTests
    {
        [TestMethod()]
        public void RemoveElement()
        {
            int[] nums = { 4,5 };
            int res = LeetCode._27_Remove_Element.RemoveElement(nums, 4);
            Assert.AreEqual(1, res);
        }
    }
}
