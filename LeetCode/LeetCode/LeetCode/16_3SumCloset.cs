using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _16_3SumCloset
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int start = 0;
            int end = nums.Length - 1;
            int mid = (start + end) / 2;
            while(start < mid)
            {
                if (nums[mid] < target)
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                }
                else
                    break;
            }
            return nums[mid - 1] + nums[mid] + nums[mid + 1];
        }
    }
}
