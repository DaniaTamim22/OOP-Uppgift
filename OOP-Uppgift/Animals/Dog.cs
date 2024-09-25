using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog sound ...");
        }
    }
}
