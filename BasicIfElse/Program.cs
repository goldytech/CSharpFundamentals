using System;

namespace BasicIfElse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageAsString = Console.ReadLine();
            var age = int.Parse(ageAsString);


            if (age > 65)
            {
                Console.WriteLine("You are a senior citizen");
            }
            else if (age >= 21)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not yet a legal adult");
            }
        }
    }
}
