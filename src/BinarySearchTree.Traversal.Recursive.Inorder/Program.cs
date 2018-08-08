using BinarySearchTree.Common;
using System;
using static BinarySearchTree.Insert.Program;

namespace BinarySearchTree.Traversal.Recursive.Inorder
{
    static class Program
    {
        static void Main(string[] args)
        {
            TreeNode<int> root = null;
            int[] values = new int[] { 10, 16, -3, 5, 6, 11 };

            foreach (var value in values)
            {
                InsertValue(ref root, value);
            }

            Inorder(root);

            Console.ReadKey();
        }

        /// <summary>
        /// Print in inorder order - Left, Visit, Right
        /// reminder inorder visits all of the nodes in sequence order
        /// </summary>
        /// <param name="root"></param>
        public static void Inorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            // left
            Inorder(root.Left);
            // visit
            Console.Write("{0}, ", root.Value);
            // right
            Inorder(root.Right);
        }
    }
}
