using System;

namespace Switch
{
    class Program
    {
        // Switch is decision making statement called switch.
        // The switch statement executes the code block depending upon the resulted value of an expression.
        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1 and 6: ");
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 6:
                case 5:
                    Console.WriteLine("You picked the biggest legal values");
                    break;
                case 4:
                    Console.WriteLine("You chose 4");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 1:
                    Console.WriteLine("You chose the lowest legal value");
                    break;
                default:
                    Console.WriteLine("Not a legal entry. Please try again.");
                    break;

            }
        }
    }
}
