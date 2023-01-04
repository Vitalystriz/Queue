using Node_home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Queue1<T>
    {
        private Node<T> First;

        private Node<T> Last;
        //-----------------------------------
        public Queue1()
        {
            this.First = null;

            this.Last = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return this.First == null;
        }
        //-----------------------------------
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.First == null)

                this.First = temp;
            else

                this.Last.SetNext(temp);

            this.Last = temp;
        }
        //-------------------------------------
        public T Remove()
        {
            T x = this.First.GetValue();

            First = First.GetNext();

            if (this.First == null)

                this.Last = null;

            return (x);
        }
        //-------------------------------------
        public T Head()
        {
            return (this.First.GetValue());
        }

        //-------------------------------------
        //הרוורס נעשה על השרשרת עצמה
        //תוך דריסת הנתונים והוצאתם מהמחסנית
        public void Reverse()
        {
            Stack<T> S = new Stack<T>();

            Node<T> Pos = this.First;

            while (Pos != null)
            {
                S.Push(Pos.GetValue());

                Pos = Pos.GetNext();
            }

            Pos = this.First;

            while (Pos != null)
            {
                Pos.SetValue(S.Pop());

                Pos = Pos.GetNext();
            }


        }
        //שמירה על התור הקיים
        //והחזרת תור חדש הרוורס של התור הקיים
        public Queue1<T> Reverse1()
        {
            Queue1<T> RevrseQ = new Queue1<T>();
            Stack<T> S = new Stack<T>();

            Node<T> Pos = this.First;

            while (Pos != null)
            {
                S.Push(Pos.GetValue());

                Pos = Pos.GetNext();
            }
            while (S.IsEmpty())
            {
                RevrseQ.Insert(S.Pop());
            }

            return RevrseQ;


        }
        public Queue1<T> CopyQueue()
        {
            Queue1<T> CopyQ = new Queue1<T>();
            Node<T> Pos = this.First;
            while (Pos != null)
            {
                CopyQ.Insert(Pos.GetValue());
                Pos = Pos.GetNext();
            }
            return CopyQ;
        }
        //-------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.First;

            while (pos != null)
            {
                st += pos.GetValue();

                if (pos.GetNext() != null)

                    st += ",";

                pos = pos.GetNext();
            }
            st += "]";
            return (st);
        }
    }
}
