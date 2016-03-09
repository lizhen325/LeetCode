using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _41_FirstMissingPositive
    {
        public static int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length <= 1) return 1;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    if (nums[i] != i + 1)
                    {
                        return i + 1;
                    }
                    else if (i == nums.Length - 1)
                        return i + 1;
                }
                
            }
            return 0;
        }
    }
}
