using BinarySearchTree.Common;
using System;

namespace BinarySearchTree.Insert
{
    /// <summary>
    /// Does BST insert
    /// 
    /// Worst case - inserting 5 - 1->2->3->4 O(n)
    /// Balanced tree - O(log n)
    /// </summary>
    public class Program
    {   
        static void Main(string[] args)
        {
            TreeNode<int> root = null;
            int[] values = new int[] { 10, 16, -3, 5, 6, 11 };

            foreach (var value in values)
            {
                InsertValue(ref root, value);
            }
        }

        /// <summary>
        /// Test inserting values in tree
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>modified tree</returns>
        public static void InsertValue(ref TreeNode<int> root, int value)
        {
            var newNode = new TreeNode<int>(value);

            // if root is null then this is the start of the tree
            if (root == null)
            {
                root = newNode;
                return;
            }

            // reference to store parent
            TreeNode<int> parent = null;
            // reference to represent the current position in the tree
            TreeNode<int> current = root;

            // traverse the tree until we end up with an empty child
            while (current != null)
            {
                // set the parent as the current node
                parent = current;

                // check if the left value is less than or equal
                if (value <= current.Value)
                {
                    // if so then set the current to the child
                    current = parent.Left;
                }
                else
                {
                    // otherwise the right
                    current = parent.Right;
                }

                // if we end up here and the child node was null then that is where we want to stick it
            }

            // set the new node
            if (value <= parent.Value)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }
        }
    }
}
