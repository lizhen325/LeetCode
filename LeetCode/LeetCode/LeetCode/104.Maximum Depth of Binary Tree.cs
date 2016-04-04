using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class _104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int leftNode = this.MaxDepth(root.left);
            int rightNode = this.MaxDepth(root.right);
            return Math.Max(leftNode, rightNode) + 1;
        }
    }
}
