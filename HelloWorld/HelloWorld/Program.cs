using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            var name = "Afzal";
            var i = 0;

            Person person;
            person = new Person("Hamir");

            person.Walk();

       
            Console.WriteLine("Hello world {0}",name);
            Console.Read();
        }
    }
}
