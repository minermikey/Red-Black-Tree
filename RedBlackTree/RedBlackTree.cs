using System;

namespace RedBlackTreeDemo
{
    public class RedBlackTree
    {
        public Node Root; // Root of the tree

        private void RotateLeft(Node x)
        {
            Node y = x.Right;
            x.Right = y.Left;
            if (y.Left != null) y.Left.Parent = x;

            y.Parent = x.Parent;

            if (x.Parent == null)
                Root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else
                x.Parent.Right = y;

            y.Left = x;
            x.Parent = y;
        }

        private void RotateRight(Node y)
        {
            Node x = y.Left;
            y.Left = x.Right;
            if (x.Right != null) x.Right.Parent = y;

            x.Parent = y.Parent;

            if (y.Parent == null)
                Root = x;
            else if (y == y.Parent.Left)
                y.Parent.Left = x;
            else
                y.Parent.Right = x;

            x.Right = y;
            y.Parent = x;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            Root = BSTInsert(Root, newNode);
            FixInsert(newNode);
        }

        private Node BSTInsert(Node root, Node node)
        {
            if (root == null)
                return node;

            if (node.Value < root.Value)
            {
                root.Left = BSTInsert(root.Left, node);
                root.Left.Parent = root;
            }
            else if (node.Value > root.Value)
            {
                root.Right = BSTInsert(root.Right, node);
                root.Right.Parent = root;
            }

            return root;
        }

        private void FixInsert(Node node)
        {
            while (node != Root && node.Parent.IsRed)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    Node uncle = node.Parent.Parent.Right;

                    if (uncle != null && uncle.IsRed)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }

                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateRight(node.Parent.Parent);
                    }
                }
                else
                {
                    Node uncle = node.Parent.Parent.Left;

                    if (uncle != null && uncle.IsRed)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }

                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateLeft(node.Parent.Parent);
                    }
                }
            }

            Root.IsRed = false;
        }

        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Value + (node.IsRed ? "(R) " : "(B) "));
                InOrder(node.Right);
            }
        }
    }
}
