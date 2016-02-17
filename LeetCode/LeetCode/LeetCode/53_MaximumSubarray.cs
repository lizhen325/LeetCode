using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int max_so_far = nums[0];
            int max_end = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                max_end = Math.Max(nums[i], max_end + nums[i]);
                max_so_far = Math.Max(max_so_far, max_end);
            }
            return max_so_far;
        }
    }
}
