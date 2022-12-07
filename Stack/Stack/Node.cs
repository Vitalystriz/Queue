using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Node<T>
    {

        private T Value;
        private Node<T> next;
        public Node(T Value)
        {
            this.Value = Value;
            this.next = null;
        }
        public Node(T Value, Node<T> next)
        {
            this.Value = Value;
            this.next = next;
        }
        public T GetValue()
        {
            return this.Value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetValue(T Value)
        {
            this.Value = Value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public bool hasNext()
        {
            return this.GetNext() != null;

        }
        public override string ToString()
        {
            return "" + this.Value;
        }

    }
}
