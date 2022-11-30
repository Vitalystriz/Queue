using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Node_home
{
    internal class station

    {
        private int x;
        private int y;
        public station(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(station other)
        {
            double x = Math.Pow((this.x - other.x), 2);
            double y = Math.Pow((this.y - other.y), 2);
            return Math.Sqrt(x + y);
        }
        public override string ToString()
        {
            return "[" + this.x + " , " + this.y + "]";
        }
    }
}
