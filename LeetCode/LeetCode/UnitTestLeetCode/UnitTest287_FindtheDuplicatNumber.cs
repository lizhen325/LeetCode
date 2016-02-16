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
    public class UnitTest287_FindtheDuplicatNumber
    {
        [TestMethod()]
        public void FindtheDuplicatNumber()
        {
            int[] nums = { 2, 2, 2, 3, 4, 5 };
            int duplicateNumber = _287FindtheDuplicateNumber.FindDuplicate(nums);
            Assert.AreEqual(2, duplicateNumber);
        }
    }
}
