using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        // Root of Binary Tree
        public Node root;

        BinaryTree()
        {
            root = null;
        }

        /* Given a binary tree, print its nodes according to the
          "bottom-up" postorder traversal. */
        public void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            printPostorder(node.left);

            // then recur on right subtree
            printPostorder(node.right);

            // now deal with the node
            Console.WriteLine(node.key + " ");
        }

        /* Given a binary tree, print its nodes in inorder*/
        public void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.WriteLine(node.key + " ");

            /* now recur on right child */
            printInorder(node.right);
        }

        /* Given a binary tree, print its nodes in preorder*/
        public void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.WriteLine(node.key + " ");

            /* then recur on left sutree */
            printPreorder(node.left);

            /* now recur on right subtree */
            printPreorder(node.right);
        }

        // Wrappers over above recursive functions
        public void printPostorder()
        {
            printPostorder(root);
        }

        public void printInorder()
        {
            printInorder(root);
        }

        public void printPreorder()
        {
            printPreorder(root);
        }
    }
}
