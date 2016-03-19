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
    public class _290_WordPatternTests
    {
        [TestMethod()]
        public void WordPatternTest()
        {
            string pattern = "abba";
            string words = "dog cat cat dog";
            bool res = LeetCode._290_WordPattern.WordPattern(pattern, words);
            Assert.AreEqual(true, res);

            string pattern1 = "abba";
            string words1 = "dog cat, cat, fish";
            bool res1 = LeetCode._290_WordPattern.WordPattern(pattern1, words1);
            Assert.AreEqual(false, res1);

            string pattern2 = "abba";
            string words2 = "dog dog dog dog";
            bool res2 = LeetCode._290_WordPattern.WordPattern(pattern2, words2);
            Assert.AreEqual(false, res2);
        }
    }
}
