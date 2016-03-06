using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _27_Remove_Element
    {
        public static int RemoveElement(int[] nums, int val)
        {
            
            int j = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j++;
                }
            }
            return j;
        }
    }
}
