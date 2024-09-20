namespace OOP_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kalle","Testson",37,170,70);
            Console.WriteLine(person.FName);
            Console.WriteLine(person.ToString());
        }
    }
}
