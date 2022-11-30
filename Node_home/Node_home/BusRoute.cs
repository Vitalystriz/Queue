using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_home
{
    internal class BusRoute
    {
        private Node<station> BR;
        public BusRoute(station First, station Second)
        {
            this.BR = new Node<station>(First);
            this.BR.SetNext(new Node<station>(First));
        }
        public void AddStation(station Newstation)
        {
            Node<station> pos = this.BR;
            while (pos.GetNext() != null)
            {
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<station>(Newstation));
        }
        public double TotalDiatance()
        {
            double result = 0;
            Node<station> pos = this.BR;
            while (pos.GetNext() != null)
            {
                result += pos.GetValue().Distance(pos.GetNext().GetValue());
                pos = pos.GetNext();
            }
            return result;
        }
    }
}
