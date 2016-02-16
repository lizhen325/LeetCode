using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MoveZeroes
    {
        public void Move_zeroes(int[] nums)
        {
            // Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

            //For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0]. 

            int current = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }

            for(int i=current; i<nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
