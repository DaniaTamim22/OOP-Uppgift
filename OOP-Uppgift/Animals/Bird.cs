using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Bird : Animal
    {
        //F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
        //attribut, i vilken klass bör vi lägga det?
        //S. Man ska lägga den har i Bird classen då alla birds ärvar den .

        private int wingSpan;
        public int WingSpan { get => wingSpan; set => wingSpan = value; }
        public Bird(string name, int weight, int age, int wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }



        public override void DoSound()
        {
            Console.WriteLine("Bird sound .."); ;
        }
    }
}
