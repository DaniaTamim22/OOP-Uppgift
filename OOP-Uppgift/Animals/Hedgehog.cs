using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Hedgehog : Animal
    {
        private int numOfSpikes;
        public int NumOfSpike { get { return numOfSpikes; } set { numOfSpikes = value; } }
        public Hedgehog(string name, int weight, int age, int numOfSpike) : base(name, weight, age)
        {
            NumOfSpike = numOfSpike;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound .."); ;
        }
    }
}
