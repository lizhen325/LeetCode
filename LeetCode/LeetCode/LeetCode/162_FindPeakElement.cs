using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _162_FindPeakElement
    {
        public static int FindPeakElement(int[] nums)
        {
            if(nums.Length<=1)
            {
                return nums.Length - 1;
            }
            for(int i=1; i<nums.Length; i++)
            {
                if(i < nums.Length-1)
                {
                    if (nums[i] > nums[i - 1] && nums[i + 1] < nums[i])
                    {
                        return i;
                    }
                }
                if (nums[i] < nums[i - 1])
                {
                    return i - 1;
                }
   
                if(i > nums.Length-2)
                {
                    return nums.Length - 1;
                }                            
            }
            return 0;
        }
    }
}
