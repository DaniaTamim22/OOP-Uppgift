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


        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        internal void printPerson(Person p1)
        {
            Console.WriteLine(p1.ToString());

        }
    }
}
