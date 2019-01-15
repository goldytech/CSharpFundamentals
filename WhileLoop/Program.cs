using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // while loop to execute a block of code repeatedly until the bool expression returns true
            while (i < 10)
            {
                Console.WriteLine($"Value of i: {i}");

                i++;
            }

            // infinite loop
            Console.WriteLine("type exit to terminate loop");
            while (true)
            {
                Console.WriteLine("Enter your name");
                var name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                Console.WriteLine($"Hello {name}");
            
            }
        }
    }
}
