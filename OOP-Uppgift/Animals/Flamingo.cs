using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Flamingo : Bird
    {
        private string flamingoColor;

        public string FlamingoColor { get; set; }
        public Flamingo(string name, int weight, int age, int wingSpan, string flamingoColor) : base(name, weight, age, wingSpan)
        {
            FlamingoColor = flamingoColor;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flamingo sound .. ");
        }
    }
}
