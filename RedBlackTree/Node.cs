using System;

namespace RedBlackTreeDemo
{
    public class Node
    {
        public int Value;           
        public Node Left;           
        public Node Right;          
        public Node Parent;         
        public bool IsRed;          

        public Node(int value)
        {
            Value = value;
            IsRed = true;  // new nodes are red
        }
    }
}
