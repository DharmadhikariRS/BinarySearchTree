using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTreeNode<K>
    {
        public K Key;
        public BinarySearchTreeNode<K> Right;
        public BinarySearchTreeNode<K> Left;

        public BinarySearchTreeNode(K Key)
        {
            this.Key = Key;
            Right = null;
            Left = null;

        }
    }
}
