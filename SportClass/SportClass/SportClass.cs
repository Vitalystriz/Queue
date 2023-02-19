using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClass
{
    internal class SportClass
    {
        private string name; // name
        private char day; //day
        private int hour;//hour
        private int price; //price
        private int Code;
        public SportClass(string name)
        {
            this.name = name;
            this.day = 'w';
            this.hour = 8;
            this.price = 0;
            this.Code = 0;
        }
        public  char GetDay()
        {
            return day;
        }
        public int GetCode()
        {
            return Code;
        }
        public int Getprice()
        {
            return price;
        }
        public string GetName()
        {
            return name;
        }

    }
}
