using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _258_AddDigits
    {
        public static int AddDigits(int num)
        {
            return num - 9 * ((num - 1) / 9);
        }
    }
}
