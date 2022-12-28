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

        }
        static void Main(string[] args)
        {
        }
    }
}
