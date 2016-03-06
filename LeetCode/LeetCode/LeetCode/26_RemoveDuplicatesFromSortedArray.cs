using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _26_RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int [] nums)
        {
            int a = 1;
            if (nums.Length <= 1) return nums.Length;
            for(int i=1; i<nums.Length; i++)
            {
                if(nums[i] != nums[i-1])
                {
                    nums[a] = nums[i];
                    a++;
                }
            }
            return a;
        }
    }
}
