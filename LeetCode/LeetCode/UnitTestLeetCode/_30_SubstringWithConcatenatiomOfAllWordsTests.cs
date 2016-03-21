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
    public class _30_SubstringWithConcatenatiomOfAllWordsTests
    {
        [TestMethod()]
        public void FindSubStringTest()
        {
            string s = "barfoothefoobarman";
            string[] words = { "foo", "bar" };
            var list = LeetCode._30_SubstringWithConcatenatiomOfAllWords.FindSubString(s,words);
        }
    }
}
