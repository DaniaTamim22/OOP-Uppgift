﻿using System.Security.Cryptography;

namespace OOP_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FirstPart();
            SecondPart();

        }

        private static void SecondPart()
        {
            PersonHandler personHandler = new PersonHandler();
            Person p1 = personHandler.CreatePerson("Nisse", "Nilsson", 20, 178, 60);
            personHandler.printPerson(p1);
            personHandler.SetAge(p1, 25);
            personHandler.printPerson(p1);
        }

        private static void FirstPart()
        {
            try
            {
                Person person = new Person("Kalle", "Testson", 37, 170, 70);
                //Can't access private fields out of the class itself
                //Console.WriteLine(person.fName); Not working
                Console.WriteLine(person.ToString());
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
