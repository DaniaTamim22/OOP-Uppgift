using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift
{
    public class Person
    {
        private string fName;
        private string lName;
        private int age;
        private int height;
        private int weight;

        public interface IPerson
        {
            public void Talk();
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (String.IsNullOrEmpty(value) || (value.Length < 2))
                {
                    throw new ArgumentException("First Name can't be empty or lower than 2 characters!!");
                }
                else if (value.Length > 10)
                {
                    throw new ArgumentException("First Name can't be more than 10 characters!!");
                }
                else
                {
                    fName = value;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {

                if (String.IsNullOrEmpty(value) || (value.Length < 3))
                {
                    throw new ArgumentException("Last Name can't be empty or lower than 3 characters!!");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Last Name can't be more than 15 characters!!");
                }
                else
                {
                    lName = value;
                }


            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age must be over 0 year !! ");
                else
                    age = value;
            }
        }
        public int Height { get { return height; } set { height = value; } }
        public int Weight { get { return weight; } set { weight = value; } }


        public Person(string fname, string lname, int age, int height, int weight)
        {
            FName = fname;
            LName = lname;
            Age = age;
            Height = height;
            Weight = weight;

        }


        public override string ToString()
        {
            return $" Person : {this.FName} {this.LName} is  {this.Age} years old and have {this.Height} CM long and {this.Weight} kg weight \n ";
        }

    }
}
