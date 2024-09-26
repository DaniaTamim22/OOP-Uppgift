using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Horse : Animal
    {
        private string horseColor;
        public string HorseColor { get => horseColor; set => horseColor = value; }
        public Horse(string name, int weight, int age) : base(name, weight, age)
        {
            HorseColor = HorseColor;
        }



        public override void DoSound()
        {
            Console.WriteLine("Horse sound..");
        }
    }
}
