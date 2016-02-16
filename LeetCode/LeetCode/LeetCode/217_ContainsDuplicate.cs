using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ContainsDuplicate
    {
        public static bool ContainDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] += 1;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }
            foreach(var item in dic)
            {
                if(item.Value > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
