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
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] res = RemoveZeroes.MoveZeroes(nums);
            foreach(var i in res)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
