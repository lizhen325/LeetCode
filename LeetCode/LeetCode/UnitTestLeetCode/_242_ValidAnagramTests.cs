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
    public class _242_ValidAnagramTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            string s1 = "anagram";
            string t1 = "nagaram";
            bool flag1 = LeetCode._242_ValidAnagram.IsAnagram(s1, t1);
            Assert.AreEqual(true, flag1);

            string s2 = "rat";
            string t2 = "car";
            bool flag2 = LeetCode._242_ValidAnagram.IsAnagram(s2, t2);
            Assert.AreEqual(false, flag2);
        }
    }
}
