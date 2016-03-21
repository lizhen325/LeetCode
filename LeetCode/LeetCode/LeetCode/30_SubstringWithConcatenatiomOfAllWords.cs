using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode
{
    public class _30_SubstringWithConcatenatiomOfAllWords
    {
        public static IList<int> FindSubString(string s, string[] words)
        {
            var res = new List<int>();
            if (words.Length <= 0)
            {
                return res;
            }

            var hashtable = new Dictionary<string, int>();
            foreach (var str in words)
            {
                if (!hashtable.ContainsKey(str))
                {
                    hashtable.Add(str, 1);
                }
                else
                {
                    hashtable[str]++;
                }
            }

            int len = words.Length * words[0].Length;

            for (int i = 0; i < s.Length - len + 1; i++)
            {
                if (hashtable.ContainsKey(s.Substring(i, words[0].Length)))
                {
                    var newHashTable = new Dictionary<string, int>(hashtable);
                    for (int j = i; j < i + len; j += words[0].Length)
                    {
                        var str = s.Substring(j, words[0].Length);
                        if (!newHashTable.ContainsKey(str))
                        {
                            break;
                        }
                        newHashTable[str]--;
                    }
                    if (newHashTable.Values.All(value => value == 0))
                    {
                        res.Add(i);
                    }
                }
            }
            return res;
        }
    }
}
