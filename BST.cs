using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos;

namespace Algoritmos
{
    internal class Node
    {
        public Node? l = null;
        public Node? r = null;
        public int? root;
        public Node(Node? l, Node? r, int root)
        {
            this.l=l;
            this.r=r;
            this.root=root;
        }
        public Node(int root)
        {
            this.l = null;
            this.r = null;
            this.root = root;
        }
        public Node()
        {
            this.l = null;
            this.r = null;
            this.root = null;
        }
    }
    internal class Tree
    {
        public Node treeGeneration(int[] arrOrd)
        {
            if (arrOrd.Length == 1)
            {
                Node hoja = new Node(root: arrOrd[0]);
                return hoja;
            }
            int mid = arrOrd.Length/2;
            int[] arrLeft = new int[mid];
            int[] arrRight = new int[arrOrd.Length-mid-1];
            
            for (int i = 0; i < mid; i++)
            {
                arrLeft[i] = arrOrd[i];
            }
            for (int i = mid+1; i <= arrOrd.Length-1; i++)
            {
                arrRight[i-mid-1] = arrOrd[i];
            }
            Node node = new Node(l: treeGeneration(arrLeft), r: treeGeneration(arrRight), root: arrOrd[mid]);
            return node;

        }
        public void traversePreorder(Node? tree)
        {
            if (tree == null)
            {
                Console.WriteLine("se termina el arbol");
                return;
            }
            Console.WriteLine("raiz: "+tree.root);
            traversePreorder(tree.l);
            traversePreorder(tree.r);

        }
        public void traverseInorder(Node? tree)
        {
            if (tree == null)
            {
                Console.WriteLine("se termina el arbol");
                return;
            }
            
            traversePreorder(tree.l);
            Console.WriteLine("raiz: "+tree.root);
            traversePreorder(tree.r);

        }
        public void traversePostorder(Node? tree)
        {
            if (tree == null)
            {
                Console.WriteLine("se termina el arbol");
                return;
            }
            
            traversePreorder(tree.l);
            traversePreorder(tree.r);
            Console.WriteLine("raiz: "+tree.root);

        }
    }
    internal class Prueba
    {
        public static void Main(String[] args)
        {
            Tree tree = new Tree();
            int[] arr = { 1, 2, 3};
            Node node = tree.treeGeneration(arr);
            Console.WriteLine("+++            Preorden");
            tree.traversePreorder(node);
            Console.WriteLine("+++            Inorden");
            tree.traverseInorder(node);
            Console.WriteLine("+++            Postorden");
            tree.traversePostorder(node);

        }
    }
}


