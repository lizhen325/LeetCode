using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _66_PlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            for(int i=digits.Length-1; i>=0; i--)
            {
                if(digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
                if(digits[0] == 0)
                {
                    int[] NewDigits = new int[digits.Length + 1];
                    NewDigits[0] = 1;
                    return NewDigits;
                }
            }
            return digits;
        }
    }
}
