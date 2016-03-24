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
    public class _11_ContianerWithMostWaterTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            int[] height1 = {1,2,3,4,5,6,6};
            int MaxArea = LeetCode._11_ContianerWithMostWater.MaxArea(height1);
            Assert.AreEqual(5, MaxArea);
        }
    }
}
