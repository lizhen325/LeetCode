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
    public class _3_LongestSubstringTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            string str1 = "abcabccbb";
            int res = LeetCode._3_LongestSubstring.LengthOfLongestSubstring(str1);
            Assert.AreEqual(3, res);

            string str2 = "bbbbb";
            int res2 = LeetCode._3_LongestSubstring.LengthOfLongestSubstring(str2);
            Assert.AreEqual(1, res2);

            string str3 = "pwwkew";
            int res3 = LeetCode._3_LongestSubstring.LengthOfLongestSubstring(str3);
            Assert.AreEqual(3, res3);
        }
    }
}
