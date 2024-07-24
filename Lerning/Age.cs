using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernung
{
    internal class Person
    { 
     private int _age;
     public int Age
     {
       get { return _age; }
       set
       {
         if (value < 0 || value > 120)
         {
          Console.WriteLine("erorr");
         }
         else
         {
          _age = value;
         }       
       }
     }
        private string _name;
        public string Name
        {
         get { return _name; }
         set {
              if (Char.IsUpper(value[0]))
               {
                _name = value;
               } 
               else
               {
                Console.WriteLine("Erorr");
               }
            }
        }
    }
}
