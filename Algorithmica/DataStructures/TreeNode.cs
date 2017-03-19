using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmica.DataStructures
{
    public class TreeNode <T> : Node<T>
    {
		public TreeNode<T> LeftLeaf { get; set; }
		public TreeNode<T> RightLeaf { get; set; }
		public TreeNode(T data) : base(data)
		{ }
    }
}
