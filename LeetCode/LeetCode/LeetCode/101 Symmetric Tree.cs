using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _101_Symmetric_Tree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymetricRecursion(root.left, root.right);
        }

        private bool IsSymetricRecursion(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            else if (node1 == null || node2 == null) return false;
            if (node1.val != node2.val) return false;
            return IsSymetricRecursion(node1.left, node2.right) && IsSymetricRecursion(node1.right,node2.left);
        }
    }
}
