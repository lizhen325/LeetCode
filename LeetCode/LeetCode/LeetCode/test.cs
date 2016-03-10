using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class test
    {
        public static bool IsPalindrome(string str)
        {
            
            str = str.ToLower();
            Stack<char> s = new Stack<char>();
            for(int i=0; i<str.Length; i++)
            {
                if (str[i].Equals('.') || str[i].Equals(" "))
                    continue;
                s.Push(str[i]);
            }
            char[] str1 = s.ToArray();
            for(int i=0; i<str1.Length; i++)
            {
                if (!str[i].Equals(str1[i]))
                    return false;
            }
            return true;
            
        }
    }
}
