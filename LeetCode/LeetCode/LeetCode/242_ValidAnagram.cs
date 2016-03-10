using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _242_ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i=0; i<s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    dic[s[i]]++;
                else
                    dic[s[i]] = 1;
            }

           for(int i=0; i<t.Length; i++)
           {
               if (!dic.ContainsKey(t[i]) || dic[t[i]] == 0)
                   return false;
               else
                   dic[t[i]]--;
           }
           return true;

        }
    }
}
