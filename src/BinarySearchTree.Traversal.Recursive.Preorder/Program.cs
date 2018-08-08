using BinarySearchTree.Common;
using System;
using static BinarySearchTree.Insert.Program;

namespace BinarySearchTree.Traversal.Recursive.Preorder
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode<int> root = null;
            int[] values = new int[] { 10, 16, -3, 5, 6, 11 };

            foreach (var value in values)
            {
                InsertValue(ref root, value);
            }

            Preorder(root);

            Console.ReadKey();
        }

        /// <summary>
        /// Print in preorder order - Visit, Left, Right
        /// reminder preorder visits all of the root nodes before the leaf nodes
        /// </summary>
        /// <param name="root"></param>
        public static void Preorder(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }

            // visit
            Console.Write("{0}, ", root.Value);
            // left
            Preorder(root.Left);
            // right
            Preorder(root.Right);
        }
    }
}
