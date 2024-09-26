using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    public abstract class Animal
    {
        private string name;
        private int weight;
        private int age;

        //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        //S. Här i animal class då alla animals ärvar den

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(name))
                    name = "animal";
                else
                    name = value;
            }
        }
        public int Weight { get { return age; } set { age = value; } }

        public int Age { get { return age; } set { age = value; } }

        public abstract void DoSound();

        protected Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
