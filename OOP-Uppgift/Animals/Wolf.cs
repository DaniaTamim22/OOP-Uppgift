using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift.Animals
{
    internal class Wolf : Animal
    {
        private string packName;

        public string PackName {  get { return packName; } set { packName = value; } }
        public Wolf(string name, int weight, int age, string packName) : base(name, weight, age)
        {
            PackName = packName;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf sound .."); ;
        }
    }
}
