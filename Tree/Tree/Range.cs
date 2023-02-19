using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class RAnge1
    {
        private int low;
        private int hight;
        public RAnge1(int low, int hight)
        {
            this.low = low;
            this.hight = hight;
        }
        
        public int Hight()
        {
            return this.hight;
        }
        public int Low()
        {
            return this.low;
        }
    }
}
