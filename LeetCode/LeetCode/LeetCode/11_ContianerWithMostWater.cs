using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _11_ContianerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int i, j, lh, rh, area, temp;
            i = 0;
            j = height.Length - 1;
            area = 0;
            lh = height[0];
            rh = height[height.Length - 1];
            while(i<j)
            {
                temp = Math.Min(lh, rh) * (j - i);
                if (temp > area) area = temp;
                if(lh < rh)
                {
                    while(i<j && height[i] <=lh)
                    {
                        i++;
                    }
                    if (i < j) lh = height[i];
                }
                else
                {
                    while(i<j && height[j] <=rh)
                    {
                        j--;
                    }
                    if (i < j) rh = height[j];
                }
            }
            return area;
        }
    }
}
