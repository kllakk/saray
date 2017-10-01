using System;
using System.Collections.Generic;
using System.Text;

namespace StuffLibrary
{
    public class BinaryTree
    {
        private BinaryTreeNode _head;

        public void Add(int value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeNode(value);
            }
            else
            {
                AddTo(_head, value);
            }
        }

        private void AddTo(BinaryTreeNode node, int value)
        {
            if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
            else if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
        }

        public void Remove(int value)
        {
        }

        public void Contains(int value)
        {
        }
    }

    class BinaryTreeNode
    {
        public int Value { get; private set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
