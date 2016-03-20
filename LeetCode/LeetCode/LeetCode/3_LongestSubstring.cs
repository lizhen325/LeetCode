using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _3_LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dic = new Dictionary<char, int>();
                while (i < s.Length && !dic.ContainsKey(s[i])) 
                { 
                    dic.Add(s[i++], 1); 
                } 
                if (i - start > length)
                {
                    length = i - start;
                }
            }

            return length;
        }
    }
}
