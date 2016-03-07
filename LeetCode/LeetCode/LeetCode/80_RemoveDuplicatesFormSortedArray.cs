using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _80_RemoveDuplicatesFormSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int current = 0;
            int i;
            int j = 0;
            for (i=0; i < nums.Length; )
            {
                int now = nums[i];
                for (j = i; j < nums.Length; j++)
                {
                    if (nums[j] != now)
                        break;
                    if (j - i < 2)
                        nums[current++] = now;
                }
                i = j;
            }
            return current;
        }
    }
}
