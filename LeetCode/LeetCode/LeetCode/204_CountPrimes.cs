using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _204_CountPrimes
    {
        public static int CountPrimes(int n)
        {
            int count = 0;
            for(int i=1; i<n; i++)
            {
                if (isPrime(i))
                    count++;
            }
            return count;
        }

        private static bool isPrime(int num)
        {
            if (num <= 1) return false;
            int up = (int)Math.Pow(num, 0.5);
            for(int i=2; i<=up; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
