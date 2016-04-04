using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _226_Inverted_Tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var left = root.left;
            var right = root.right;
            root.right = this.InvertTree(left);
            root.left = this.InvertTree(right);

            return root;
        }
    }
}
