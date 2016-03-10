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
    public class _205_IsmorphicStringsTests
    {
        [TestMethod()]
        public void IsmorphicStringTest()
        {
            string s = "ab";
            string t = "aa";
            bool res = LeetCode._205_IsmorphicStrings.IsmorphicString(s, t);
            Assert.AreEqual(false, res);
        }
    }
}
