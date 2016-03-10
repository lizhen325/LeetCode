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
    public class _202_IsHappyNumberTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            bool flag1 = LeetCode._202_IsHappyNumber.IsHappy(19);
            Assert.AreEqual(true, flag1);
        }
    }
}
