using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Swan : Bird
    {
        private bool isGraceful;

        public bool IsGraceful { get; set; }
        public Swan(string name, int weight, int age, int wingSpan, bool isGraceful) : base(name, weight, age, wingSpan)
        {
            IsGraceful = isGraceful;
        }

        public override void DoSound()
        {
            Console.WriteLine(" Swan Sound .. ");
        }
    }
}
