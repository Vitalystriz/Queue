using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_pro
{
    internal class Stack1<T>
    {
        private Node<T> First;

        public Stack1()
        {
            this.First = null;
        }

        public bool IsEmpty()
        {
            if (this.First == null) { return true; }
            return false;
        }


        public void Push(T x)
        {
            this.First = new Node<T>(x, this.First);
        }

        public T Pop()
        {
            T x = this.First.GetValue();
            this.First = this.First.GetNext();

            return x;
        }

        public T Top()
        {
            return this.First.GetValue();
        }
        public Stack1<T> CopySt()
        {
            Node<T> Pos = this.First;
            Stack1<T> Copy = new Stack1<T>();
            Stack1<T> Temp = new Stack1<T>();
            while (Pos != null)
            {
                T X = Pos.GetValue();
                Temp.Push(X);
                Pos = Pos.GetNext();
            }
            while (!Temp.IsEmpty())
            {
                Copy.Push(Temp.Pop());

            }
            return Copy;
        }
        public override string ToString()
        {
            string str = "[";

            Node<T> pos = this.First;
            while (pos != null)
            {
                str = str + pos.GetValue().ToString();
                if (pos.GetNext() != null)
                    str = str += ",";
                pos = pos.GetNext();
            }
            str = str + "]";
            return str;
        }
    }
}
