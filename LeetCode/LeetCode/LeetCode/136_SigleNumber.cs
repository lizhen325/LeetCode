using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _136_SigleNumber
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic[nums[i]] = 1;
            }

            foreach(KeyValuePair<int,int> i in dic)
            {
                if (i.Value == 1)
                    return i.Key;
            }
            return 0;
        }
    }
}
