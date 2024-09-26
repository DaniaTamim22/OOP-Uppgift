using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Worm : Animal
    {
        private bool isPoisnous;

        public bool IsPoisnous { get => isPoisnous; set => isPoisnous = value; }

        public Worm(string name, int weight, int age, bool isPoisnous) : base(name, weight, age)
        {
            IsPoisnous = isPoisnous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm sound .. "); ;
        }
    }
}
