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
    public class UnitTestProductOfArrayExceptSelf
    {
        [TestMethod()]
        public void ProductExcpetSelf()
        {
            int[] arr = { 2, 3, 5, 7, 1, 4 };
            int[] res = ProductOfArrayExceptSelf.ProductExceptSelf(arr);
            CollectionAssert.AreEqual(new int[] { 420, 280, 168, 120, 840, 210 }, res);
        }
    }
}
