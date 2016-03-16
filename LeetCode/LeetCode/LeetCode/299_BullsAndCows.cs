using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _299_BullsAndCows
    {
        public static string GetHint(string secret, string guess)
        {
            // secret: "1807"
            // guess:  "7810"
            // hint: "1A3B"
            if (secret == null || guess == null || secret.Length != guess.Length)
            {
                return "";
            }

            int countA = 0;
            int countB = 0;

            char[] arrA = secret.ToCharArray();
            char[] arrB = guess.ToCharArray();

            //count A
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == ' ' || arrB[j] == ' ')
                    {
                        continue;
                    }
                    else if (arrA[i] == arrB[j])
                    {
                        if (i == j)
                        {
                            countA++;
                            arrA[i] = ' ';
                            arrB[j] = ' ';
                        }
                    }
                }
            }

            //count B
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == ' ' || arrB[j] == ' ')
                    {
                        continue;
                    }
                    else if (arrA[i] == arrB[j])
                    {
                        countB++;
                        arrA[i] = ' ';
                        arrB[j] = ' ';
                    }
                }
            }

            return countA + "A" + countB + "B";
        }
    }
}
