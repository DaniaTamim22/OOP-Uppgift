using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Bird : Animal
    {
        private int wingSpan;
        public int WingSpan { get => wingSpan; set => wingSpan = value; }
        public Bird(string name, int weight, int age,int wingSpan) : base(name, weight, age)
        { 
            WingSpan = wingSpan;
        }

      

        public override void DoSound()
        {
            Console.WriteLine("Bird sound .."); ;
        }
    }
}
