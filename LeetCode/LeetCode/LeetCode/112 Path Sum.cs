﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _112_Path_Sum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if(root.left ==null && root.right == null)
            {
                if (root.val == sum)
                    return true;
            }
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
