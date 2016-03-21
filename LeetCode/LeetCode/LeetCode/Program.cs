using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeLinQ;

namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            string s = "barfoothefoobarman";
            string[] words = {"foo","bar"};
            int lenth = 3;
            string[] str = new string[7];
            int[] res = new int[2];
            for (int i = 0, j = 0; i < s.Length; j++)
            {
                str[j] = s.Substring(i, 3);
                i = i + lenth;
            }
            for (int i = 0; i < str.Length; i++ )
            {
                if(string.Compare(str[i],words[0]) == 0)
                {
                    if(string.Compare(str[i+1],words[1]) == 0)
                    {
                        res[0] = 0;
                        res[1] = i * 3;
                    }
                }
            }

            foreach (var item in res)
                Console.WriteLine(item);
                Console.ReadKey();
        }
    }
}
