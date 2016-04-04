using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _110_Balanced_Binary_Tree
    {
        public bool IsBalanced(TreeNode root)
        {
            int leftNode = 0;
            int rightNode = 0;

        }

        private int GetHeight(TreeNode root)
        {
            int leftNode = GetHeight(root.left);
            int rightNode = GetHeight(root.right);
            return Math.Abs(leftNode - rightNode);
        }
    }
}
