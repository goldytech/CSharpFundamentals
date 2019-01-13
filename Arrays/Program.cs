using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var cricketers = new string[5];
            cricketers[0] = "Sachin";
            cricketers[1] = "Bradman";
            cricketers[2] = "Virat";
            cricketers[3] = "Dhoni";
            cricketers[4] = "Ponting";

            Console.WriteLine("Cricketers...");
            foreach (var s in cricketers)
            {
                Console.WriteLine(s);
            }

            Array.Sort(cricketers);
            var cricketerFound = Array.Find(cricketers, (x) => x == "Dhoni");

            Console.WriteLine($"Found dhoni {cricketerFound}");

            Console.WriteLine("Sorted Cricketers...");
            foreach (string s in cricketers)
            {
                Console.WriteLine(s);
            }

            Console.Read();
        }
    }
}
