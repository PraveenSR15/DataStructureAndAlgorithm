using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.Trees
{
    public class BinarySearchTree<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public TNode Value { get; private set; }
        public BinarySearchTree<TNode> Left;
        public BinarySearchTree<TNode> Right;
        public BinarySearchTree(TNode value) => Value = value;

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other) ;
        }
    }

}
