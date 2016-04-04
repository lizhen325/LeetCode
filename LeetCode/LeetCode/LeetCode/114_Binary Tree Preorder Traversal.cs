using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _114_Binary_Tree_Preorder_Traversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if(root != null)
            {
                stack.Push(root);
            }
            while(stack.Count != 0)
            {
                TreeNode currentNode = stack.Pop();
                list.Add(currentNode.val);
                if (currentNode.right != null)
                    stack.Push(currentNode.right);
                if (currentNode.left != null)
                    stack.Push(currentNode.left);
            }
            return list;
        }
}
