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
    public class UnitTest217ContainsDuplicate
    {
        [TestMethod()]
        public void ContainDuplicate()
        {
            int[]nums = {1,1,2,3,4,5};
            bool flag = ContainsDuplicate.ContainDuplicate(nums);
            Assert.AreEqual(true, flag);
        }
    }
}
