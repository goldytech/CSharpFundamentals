using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(r.Next());
            }

            myList.Sort();

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
