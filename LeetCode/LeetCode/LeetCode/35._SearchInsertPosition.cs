using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class _35
    {
        public static int SearchInsert(int[]nums,int target)
        {
            int i;
            for(i=0; i<nums.Length; i++)
            {
                if (nums[i + 1] >= target && nums[i] < target && nums.Length > 1)
                    return i + 1;
                else if (nums[i] >= target)
                    return i;
                else if (nums[nums.Length - 1] < target)
                    return nums.Length;
                else if (nums[i] == target)
                    return i;
            }
            return i;
        }
    }
}
