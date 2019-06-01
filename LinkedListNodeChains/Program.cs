using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNodeChains
{
   public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }                
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value=3};
            Node Middle = new Node { Value = 5 };

            //Linked first node with middle node.
            first.Next = Middle;

            Node Last = new Node { Value = 7 };
            //Linked middle node with last node
            Middle.Next = Last;

            //called method to print all linked nodes
            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node);
                node = node.Next;
            }                    
        }
    }
}
