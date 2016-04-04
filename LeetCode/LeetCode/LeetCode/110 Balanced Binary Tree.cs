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
            if (root == null)
                return true;
            if(Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <=1 )
            {
                return IsBalanced(root.left) && IsBalanced(root.right);
            }
            return false;
        }

        private int GetHeight(TreeNode root)
        {
            if (root == null) return 0;
            int leftNode = GetHeight(root.left);
            int rightNode = GetHeight(root.right);
            return Math.Max(leftNode, rightNode) + 1;
        }
    }
}
