using System;
using System.Collections.Generic;
using System.Linq;

namespace CousinsInBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(1);
            node.left = new TreeNode(2);
            node.left.left = new TreeNode(4);
            node.right= new TreeNode(3);
            bool test = IsCousins(node,3,4);

            Console.WriteLine("Hello World!");
        }
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            var queue = new Queue<TreeNode>(new[] { root });
            while (queue.Any())
            {
                for (int i = queue.Count, iX = 0, iY = 0; i > 0; i--)
                {
                    var node = queue.Dequeue();
                    if (node == null) continue;
                    if (node.val == x) iX = i;
                    if (node.val == y) iY = i;
                    if (iX > 0 && iY > 0)
                        return Math.Abs(iX - iY) > 1 || Math.Min(iX, iY) % 2 == 0;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            return false;
        }
    }
}
