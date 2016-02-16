using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            res[nums.Length - 1] = 1;
            for (int i = nums.Length - 1; i > 0; i-- )
            {
                res[i - 1] = res[i] * nums[i]; 
            }
            int left = 1;
            for (int i = 0; i < nums.Length; i++ )
            {
                res[i] = res[i] * left;
                left = left * nums[i];
            }
                return res;
        }
    }
}
