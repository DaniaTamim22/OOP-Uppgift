using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Pelican : Bird
    {
        private double beakLength;

        public double BeakLength { get; set; }
        public Pelican(string name, int weight, int age, int wingSpan, double beakLength) : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }

        public override void DoSound()
        {
            Console.WriteLine(" Pelican Sound .. ");
        }
    }
}
