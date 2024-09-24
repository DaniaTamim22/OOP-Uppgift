using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift
{
    internal class PersonHandler
    {
        public Person CreatePerson(string fname, string lname, int age, int height, int weight)
        {
            Person person = new Person(fname, lname, age, height, weight);
            return person;
        }


        public void SetFirstName(Person person, string firstName)
        {
            person.FName = firstName;
        }

        public void SetLastName(Person person, string lastName)
        {
            person.LName = lastName;
        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetHeight(Person person, int height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, int weight)
        {
            person.Weight = weight;
        }

        internal void printPerson(Person p1)
        {
            Console.WriteLine(p1.ToString());

        }
    }
}
