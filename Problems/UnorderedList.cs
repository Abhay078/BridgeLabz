using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Problems
{
    

    internal class UnorderedList<T>
    {
       public Node<T> First { get; private set; }
        public Node<T> Last { get; private set;}
        public int Count { get; private set; }

        public UnorderedList()
        {
            this.First = null;
            this.Last = null;

        }
        public void AddFirst(Node <T> node)
        {
            if (this.First == null)
            {
                this.First = node;
                this.Last = node;
            }
            else
            {
                node.Next= this.First;
                this.First= node;
            }
            Count++;
        }
        public void AddLast(Node <T> node)
        {
            if (this.First == null)
            {
                this.First = node;
                this.Last = node;
            }
            else
            {
                this.Last.Next= node;
                Last = node;
            }
            Count++;
        }
        public void  search(T value)
        {
            Node<T> currentNode = First;
            int found = 0;
            int i = 0;
            if(currentNode != null )
            {
                while(currentNode != null )
                {
                    i++;
                    if (currentNode.Value.Equals(value))
                    {
                        found++;
                        break;
                    }
                    currentNode= currentNode.Next;
                }
                if (found == 1)
                {
                    Console.WriteLine(value + " is found at index = " + i);
                    Remove(currentNode);
                   
                }
                else
                {
                    Console.WriteLine("The node is not found ");
                    Console.WriteLine("Adding to last");
                    Node<T> node = new Node<T>(value);
                    AddLast(node);
                   

                }
            }
        }
        public void Remove(Node<T> Toremove)
        {
            if(First==null || this.Count == 0)
            {
                return;
            }
            if(this.First==Toremove)
            {
                this.First = First.Next;
                this.Count--;
            }
            Node<T> prev = First;
            Node<T> curr=prev.Next;
            while(curr!=null && curr != Toremove)
            {
                prev = curr;
                curr = prev.Next;

            }
            if (curr != null)
            {
                prev.Next = curr.Next;
                this.Count--;
            }
        }
        public void Traverse()
        {
            Console.WriteLine("\nFirst" + this.First.Value);
            Console.WriteLine("\nLast" + this.Last.Value);

            Node<T> node= this.First;
            while (node.Next != null)
            {
                Console.WriteLine(node.Value);
                node= node.Next;
            }
            Console.WriteLine(node.Value);
        }
      
    }
}


