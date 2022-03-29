using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(6);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(3);
            

            binaryTree.TravarsePreorder(binaryTree.Root);

        }
    }
}