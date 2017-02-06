using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
 
            Console.WriteLine("Preorder traversal of binary tree is ");
            tree.printPreorder();
 
            Console.WriteLine("\nInorder traversal of binary tree is ");
            tree.printInorder();

            Console.WriteLine("\nPostorder traversal of binary tree is ");
            tree.printPostorder();

            Console.ReadKey();
        }
    }
}
