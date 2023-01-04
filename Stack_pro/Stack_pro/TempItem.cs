using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack_pro
{
    internal class TempItem
    {
        public int num1;
        public int num2;
        public TempItem(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //public void Setnums(int num1,int num2)
        //{
        //    this.num1 = num1;
        //    this.num2 = num2;

        //}
        public int Get1()
        {
            return this.num1;
        }
        public int Get2()
        {
            return this.num2;
        }
        public override string ToString()
        {
            
            string str ="("+this.num1+","+this.num2+")";
            return str;
        }


    }
}
