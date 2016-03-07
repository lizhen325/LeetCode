using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _81_SearchInRotatedSortedArrayII
    {
        public static bool Search(int[] nums, int target)
        {
            Array.Sort(nums);
            if(nums.Length <= 1)
            {
                if (nums[0] == target)
                    return true;
                else
                    return false;
            }
            int upper = nums.Length - 1;
            int lower = 0;
            int mid;
            while(lower <= upper)
            {
                mid = Convert.ToInt32(lower+(upper-lower) / 2);
                if (nums[mid] == target)
                    return true;
                else
                {
                    if (nums[mid] > target)
                        upper = mid - 1;
                    else
                        lower = mid + 1;
                }
            }
            return false;
        }
    }
}
