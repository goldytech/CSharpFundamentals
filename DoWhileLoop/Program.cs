using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    // The do-while loop is the same as a 'while' loop except that the block of code will be executed at least once,
    // // because it first executes the block of code and then it checks the condition.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine($"Happy Birthday {age} ");
                age--;
            } while (age != 0);

            Console.WriteLine("TaDa!!");
            Console.Read();
        }
    }
    }

