// Reffrences : https://www.geeksforgeeks.org/dsa/introduction-to-red-black-tree/
//

using System;

namespace RedBlackTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBlackTree tree = new RedBlackTree();

            int[] values = { 10, 20, 30, 15, 25, 5, 1 };
            foreach (int val in values)
            {
                tree.Insert(val);
            }

            Console.WriteLine("In-order traversal with colors:");
            tree.InOrder(tree.Root);
        }
    }
}
/*

Visual Representation of the tree

         20(B)
        /    \
     15(B)   30(B)
     /      /
   5(B)   25(R)
  / \
1(R) 10(R)


*/