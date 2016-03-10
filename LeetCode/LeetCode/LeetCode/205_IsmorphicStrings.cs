using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _205_IsmorphicStrings
    {
        public static bool IsmorphicString(string s, string t)
        {
            //"egg" "add" return true;
            //"foo" "bar" return false;
            //"paper" "title" return false;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for(int i=0; i<s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    sb1.Append(dic[s[i]]);
                else
                {
                    dic.Add(s[i], Convert.ToChar(i));
                    sb1.Append(Convert.ToChar(i));
                }
            }
            dic.Clear();
            for(int i=0; i<t.Length;i++)
            {
                if (dic.ContainsKey(t[i]))
                    sb2.Append(dic[t[i]]);
                else
                {
                    dic.Add(t[i], Convert.ToChar(i));
                    sb2.Append(Convert.ToChar(i));
                }
            }
            return sb1.ToString() == sb2.ToString();
        }

    }
}
