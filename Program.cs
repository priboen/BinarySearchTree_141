using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    //A node class consist of three things, the information, refrences to the right child, and references to the left child
    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null;

        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            //This function search the currentNode of the specified Node as well as the current Node of its parents
            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element) //insert a node in the binary search tree
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null) //check if the node to be inserted already inserted or not
            {
                Console.WriteLine("Duplicate words not allowed.");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void inorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.Write("Tree is Empty!");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }
        public void preorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.Write("Tree is Empty!");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }
        public void postorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.Write("Tree is Empty!");
                return;
            }
            if (ptr != null)
            {
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
                Console.Write(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implementasi Insert Option");
                Console.WriteLine("2. Perform InOrder Traversal");
                Console.WriteLine("3. Perform PreOrder Traversal");
                Console.WriteLine("4. Perform PostOrder Traversal");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice: ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.WriteLine("enter a word :");
                            string word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preorder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postorder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("invalid option");
                            break;
                        }
                }
            }
        }
    }
}
