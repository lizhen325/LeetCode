using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _290_WordPattern
    {
        public static bool WordPattern(string pattern, string str)
        {

            // pattern = "abba", str = "dog cat cat dog" should return true.
            // pattern = "abba", str = "dog cat cat fish" should return false.
            // pattern = "aaaa", str = "dog cat cat dog" should return false.
            // pattern = "abba", str = "dog dog dog dog" should return false.
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dic2 = new Dictionary<string, char>();
            string[] words = str.Split(' ');
            //string[] words = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (pattern.Length != words.Length) return false;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dic.ContainsKey(pattern[i]) && !dic2.ContainsKey(words[i]))
                {
                    dic.Add(pattern[i], words[i]);
                    dic2.Add(words[i], pattern[i]);
                }
                else if (dic.ContainsKey(pattern[i]) && dic2.ContainsKey(words[i])
               && dic[pattern[i]] == words[i] && dic2[words[i]] == pattern[i])
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
