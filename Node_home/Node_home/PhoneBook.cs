using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_home
{
    internal class PhoneBook
    {
          
        private Node<Contact> PhoneL;
        public PhoneBook()
        {
            this.PhoneL = null;
        }
        public Node<Contact> IsExist(Contact C)
        {
            Node<Contact> Pos = this.PhoneL;
            while (Pos != null)
            {
                if (Pos.GetValue().GetPhone().Equals(C.GetPhone()))
                {
                    return Pos;
                }
                Pos = Pos.GetNext();
            }
            return Pos;
        }
        public void AddFist(Contact C)
        {
            Node<Contact> Pos = IsExist(C);
            if (Pos == null)
            {
                this.PhoneL = new Node<Contact>(C, this.PhoneL);
            }
        }
        public void AddLast(Contact C)
        {
            Node<Contact> Pos = IsExist(C);
            Node<Contact> Pos1 = this.PhoneL;
            if (Pos == null)
            {
                if (this.PhoneL == null)
                {
                    this.PhoneL = new Node<Contact>(C);
                }
                else
                {
                    while (Pos1.GetNext() != null)
                    {
                        Pos1 = Pos1.GetNext();
                    }
                    Pos1.SetNext(new Node<Contact>(C));
                }
            }
        }
        public void Remove(Contact C)
        {
            Node<Contact> Pos = IsExist(C);
            if (Pos != null)
            {
                Node<Contact> Pos1 = this.PhoneL;
                if (this.PhoneL == Pos)
                {
                    this.PhoneL = this.PhoneL.GetNext();
                }
                else
                {
                    while (Pos != Pos1.GetNext())
                    {
                        Pos1 = Pos1.GetNext();
                    }
                    Pos1.SetNext(Pos.GetNext());
                }
            }
        }
        public override string ToString()
        {
            string str = "";
            Node<Contact> Pos = this.PhoneL;
            while (Pos != null)
            {
                str = Pos.GetValue() + "\n";
                Pos = Pos.GetNext();
            }
            return str;
        }
    }
}

