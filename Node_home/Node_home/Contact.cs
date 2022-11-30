using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_home
{
    internal class Contact
    {
          
        private string Name; // name
        private string Telehone; // telePhone 
        public Contact(string Name, string TelePhone)
        {
            this.Name = Name;
            this.Telehone = TelePhone;
        }
        public Contact(Contact C)
        {
            this.Telehone = C.Telehone;
            this.Name = C.Name;
        }
        public string GetPhone()
        {
            return this.Telehone;
        }
    }
}

