using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_in_israeli_school
{
  
    internal class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age) { this.Name = name; this.Age = age; }
      
        public void Print()
        {
            Console.WriteLine(this.Name);
        }

    }

        
   
    


}
