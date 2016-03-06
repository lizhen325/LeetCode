using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _153_FindMinimumInRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            for(int i =1; i < nums.Length; i++)
            {
                if(nums[i] < nums[i-1])
                {
                    return nums[i];
                }
            }
            return nums[0];
        }
    }
}
