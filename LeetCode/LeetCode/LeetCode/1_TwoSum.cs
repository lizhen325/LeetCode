using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1_TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> list = new List<int>();
            for(int i=0; i<nums.Length -1; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                    }
                }
            }
            return list.ToArray();
        }
    }
}
