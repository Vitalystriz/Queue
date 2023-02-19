using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{

    class BinNode<T>
    {
        private BinNode<T> Left;

        private T Value;

        private BinNode<T> Right;

        //-----------------------------
        public BinNode(T x)
        {
            this.Left = null;

            this.Value = x;

            this.Right = null;
        }
        //-----------------------------
        public BinNode(BinNode<T> Left, T x, BinNode<T> Right)
        {
            this.Left = Left;

            this.Value = x;

            this.Right = Right;
        }
        //-----------------------------

        public T GetValue()
        {
            return (this.Value);
        }
        //-----------------------------

        public void SetValue(T x)
        {
            this.Value = x;
        }
        //-----------------------------
        public BinNode<T> GetLeft()
        {
            return (this.Left);
        }
        //-----------------------------
        public BinNode<T> GetRight()
        {
            return (this.Right);
        }
        //-----------------------------
        public void SetLeft(BinNode<T> left)
        {
            this.Left = left;
        }
        //-----------------------------
        public bool hasLeft()
        {
            return (this.Left != null);


        }
        //-----------------------------
        public bool hasRight()
        {
            return (this.Right != null);

        }
        //-----------------------------
        public void SetRight(BinNode<T> right)
        {
            this.Right = right;
        }
        //-----------------------------
        public override string ToString()
        {
            return (this.Value.ToString());
        }

    }
}

