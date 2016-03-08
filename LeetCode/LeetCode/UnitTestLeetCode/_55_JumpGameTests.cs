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
    public class _55_JumpGameTests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            bool flag = LeetCode._55_JumpGame.CanJump(nums);
            Assert.AreEqual(true, flag);

            int[] nums1 = { 3, 2, 1, 0, 4 };
            bool flag1 = LeetCode._55_JumpGame.CanJump(nums1);
            Assert.AreEqual(false, flag1);

            int[] nums2 = { 1, 2 };
            bool flag2 = LeetCode._55_JumpGame.CanJump(nums2);
            Assert.AreEqual(true, flag2);

            //int[] nums3 = { 1, 0, 1, 0 };
            //bool flag3 = LeetCode._55_JumpGame.CanJump(nums3);
            //Assert.AreEqual(false, flag3);
        }
    }
}
