using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree.Common
{
    public class TreeNode<TValue>
    {
        public TValue Value { get; private set; }

        public TreeNode<TValue> Left { get; set; } = null;
        public TreeNode<TValue> Right { get; set; } = null;

        public TreeNode(TValue value)
        {
            Value = value;
        }
    }
}
