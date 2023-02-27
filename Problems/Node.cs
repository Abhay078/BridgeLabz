using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; internal set; }
        public Node(T data)
        {
            this.Value= data;
        }
    }
}
