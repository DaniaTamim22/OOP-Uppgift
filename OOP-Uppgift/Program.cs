﻿namespace OOP_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kalle","Testson",37,170,70);
            //Can't access private fields out of the class itself
            //Console.WriteLine(person.fName); Not working
            Console.WriteLine(person.ToString());
        }
    }
}
