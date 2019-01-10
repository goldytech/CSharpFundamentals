using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var aArray = new int[] { 1, 2, 3, 4, 5, 6, 7 }; //declare the array of int type and initialize it.
            // The for loop executes a block of statements repeatedly until the specified condition returns false.
            for (var items = 0; items < aArray.Length; items++)
            {
                Console.WriteLine(items);
            }



            // foreach loop begin 
            // it will run till the 
            // last element of the array 
            foreach (var items in aArray)
            {
                Console.WriteLine(items);
            }


            // The difference between PostFix and PreFix operators the forms is what is returned.
            // The Postfix form returns the original value,
            // whereas the Prefix form increments the value and returns the result of the increment
            int age = 35;
            var newAge = ++age;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            newAge = age++;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);
        }
    }
}
