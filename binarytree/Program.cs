using StuffLibrary;
using System;

namespace binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(8);
            tree.Add(4);
            tree.Add(2);
            tree.Add(3);
            tree.Add(10);
            tree.Add(6);
            tree.Add(7);

            Console.ReadLine();
        }
    }
}