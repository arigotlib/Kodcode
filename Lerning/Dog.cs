using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernung
{
    public class Dog
    {
        public float Height;
        public float Weight;
        public string Name;
        public string Food;
        public int MaxSpeed;

        public Dog() { }
        public Dog(float height, float weight, string name, string food)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Food = food;
        }
      
        public void Size() 
        {
            Console.WriteLine("Height:" + Height, "Weight:" + Weight);
        }

        public void Run() 
        {
            Console.WriteLine(Name + "Iz Runing");
        }

        public void Eat() 
        {
            Console.WriteLine(Name + "Iz Eating");
        }

        public void Plye() 
        {
            Console.WriteLine(Name + "Iz Plyeing");
        }
       
    }
}
