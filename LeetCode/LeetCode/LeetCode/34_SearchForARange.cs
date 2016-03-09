using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _34_SearchForARange
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == target)
                    return new int[] { 0,0 };
            }
            if (nums.Length == 0)
                return new int[] { -1, -1 };
            int end = nums.Length - 1;
            int start = 0;    
            int mid = (end + start) / 2;
            //find first target
            while(start < end)
            {               
                if (nums[mid] < target)
                {
                    start = mid + 1;
                    mid = (end + start) / 2;
                }                    
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                    mid = (end + start) / 2;
                }                   
                else
                    break;
            }
            if (nums[mid] != target)
                return new int[] { -1, -1 };
            //left
            for (start = mid; start>=0; start-- )
            {
                if(nums[start] != target)
                    break;
            }
            //right
            for(end = mid; end<nums.Length; end++)
            {
                if (nums[end] != target)
                    break;
            }
            return new int[] { start + 1, end - 1 };
                
        }
    }
}
