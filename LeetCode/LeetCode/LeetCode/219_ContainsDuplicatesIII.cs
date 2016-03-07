using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _219_ContainsDuplicatesIII
    {
        public static bool ContainNearByDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (i - dic[nums[i]] <= k)
                        return true;
                    else
                        dic[nums[i]] = i;
                }
                else
                    dic.Add(nums[i], i);
            }
            return false;
        }
    }
}
