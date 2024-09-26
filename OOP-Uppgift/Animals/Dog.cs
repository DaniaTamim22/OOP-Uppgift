using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Dog : Animal
    {
        private string breed;

        public string Breed { get { return breed; } set { breed = value; } }
        public Dog(string name, int weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog sound ...");
        }
    }
}
