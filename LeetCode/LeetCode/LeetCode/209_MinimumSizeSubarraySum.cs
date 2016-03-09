using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _209_MinimumSizeSubarraySum
    {
        public static int MinSubArrayLen(int s, int[] nums)
        {
            Array.Sort(nums);
            List<int> list = new List<int>();
            if (nums.Length <= 1) return 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (s - nums[i] > 0 && i > 0)
                {
                    list.Add(nums[i]);
                    s = s - nums[i];
                }
                else if (s - nums[i] < 0)
                {
                    continue;
                }
                else if (s - nums[i] < 0 && i > 0)
                {
                    continue;
                }
                else if (s - nums[i] > 0 && i == 0)
                {
                    list.Add(nums[i]);
                    s = s - nums[i];
                    return s;
                }
                else if (s - nums[i] == 0)
                {
                    list.Add(nums[i]);
                    s = s - nums[i];
                    break;
                }
            }
            return list.Count;
        }
    }
}
