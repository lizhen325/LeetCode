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
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string guess = "7810";
            for (int i = 0; i < guess.Length; i++)
            {
                dic[guess[i]] = i;
            }

            foreach (var item in dic)
                Console.WriteLine(item.Key + ": " + item.Value);
            Console.ReadKey();
        }
    }
}
