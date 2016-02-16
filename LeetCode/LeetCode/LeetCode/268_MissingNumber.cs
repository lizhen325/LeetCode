using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class _268
    {
        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int counter;
            for(counter=0; counter<nums.Length; counter++)
            {
                if(counter!= nums[counter])
                {
                    return counter;
                }
            }
            return counter;
        }
    }
}
