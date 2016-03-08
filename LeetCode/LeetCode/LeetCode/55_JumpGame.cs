using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _55_JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            if (nums.Length == 1) return true;
            if (nums[0] == 0) return false;

            for(int i=1; i<nums.Length - 1; i++)
            {
                if (nums[i] != 0)
                    continue;
                for(int j=i-1, val=1; j>=0; j--,val++)
                {
                    if (nums[j] > val)
                        break;
                    else if (j > 0)
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
