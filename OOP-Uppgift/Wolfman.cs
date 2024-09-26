using OOP_Uppgift.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_Uppgift.Person;

namespace OOP_Uppgift
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int weight, int age, string packName) : base(name, weight, age, packName)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Wolfman Speaks ....");
        }
    }
}
