using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift
{
    internal class Person
    {
        private string fName;
        private string lName;
        private int age;
        private int height;
        private int weight;


        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public int Age { get { return age; } set {     age = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int Weight { get { return weight; } set { weight = value; } }


        public Person(string fname, string lname, int age, int height, int weight)
        {
            this.FName = fname;
            this.LName = lname;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;

        }


        public override string ToString()
        {
            return $" Person : {this.FName} {this.LName} is  {this.Age} years old and have {this.Height} CM long and {this.Weight} kg weight \n ";
        }

    }
}
