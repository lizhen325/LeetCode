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
    public class UnitTest283_MoveZeroes
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            int[] arr = { 1, 2, 3, 0, 0, 2, 4, 2, 0, 4 };
            MoveZeroes mz = new MoveZeroes();
            mz.Move_zeroes(arr);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 2, 4, 2, 4, 0, 0, 0 },arr);
        }
    }
}
