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
    public class testTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            string str = "Noel sees Leon.";
            bool flag = LeetCode.test.IsPalindrome(str);
            Assert.AreEqual(true, flag);
        }
    }
}
