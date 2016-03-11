using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLinQ
{
    public class RemoveZeroes
    {
        public static int[] MoveZeroes(int[] nums)
        {
            IEnumerable<int> zeroes = from ze in nums
                                      where ze == 0
                                      select ze;
            IEnumerable<int> non_zeroes = from non in nums
                                          where non != 0
                                          select non;
            int[] res = non_zeroes.Concat(zeroes).ToArray();
            return res;
        }
    }
}
