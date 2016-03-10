using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _202_IsHappyNumber
    {
        public static bool IsHappy(int n)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            while(true)
            {
                if (n == 1) return true;
                if (dic.ContainsKey(n)) return false;
                dic[n] = "";
                n = Sum(n);
            }
        }

        public static int Sum(int n)
        {
            string s = n.ToString();
            int sum = 0;
            for(int i=0; i<s.Length; i++)
            {
                sum += Convert.ToInt32(s[i].ToString()) * Convert.ToInt32(s[i].ToString());
            }
            return sum;
        }
    }
}
