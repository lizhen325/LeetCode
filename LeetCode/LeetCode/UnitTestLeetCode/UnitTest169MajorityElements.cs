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
    public class UnitTest169MajorityElements
    {
        [TestMethod()]
        public void MajorityElement()
        {
            int[] nums = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
            int me = _169_Majority_Element.MajorityElement(nums);
            Assert.AreEqual(4, me);
        }
    }
}
