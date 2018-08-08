using BinarySearchTree.Common;
using System;
using static BinarySearchTree.Insert.Program;

namespace BinarySearchTree.Traversal.Recursive.Postorder
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

            Postorder(root);

            Console.ReadKey();
        }

        /// <summary>
        /// Print in postorder order - Left, Right, Visit
        /// reminder postorder visits all of the leaf nodes before the root nodes
        /// </summary>
        /// <param name="root"></param>
        public static void Postorder(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }

            // left
            Postorder(root.Left);
            // right
            Postorder(root.Right);
            // visit
            Console.Write("{0}, ", root.Value);
        }
    }
}
