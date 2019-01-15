using System;
using System.Collections.Generic;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            var theStates = State.GetStates();
          
            var theState = theStates["Gujarat"];
            Console.WriteLine("The capital of Gujarat is {0}, its population is {1} and it is {2} square miles",
                theState.Capital, theState.Population, theState.Size);

            // Looping in dictionary
            foreach (KeyValuePair<string, State> keyValuePair in theStates)
            {
                Console.WriteLine($"Key is {keyValuePair.Key} Value is {keyValuePair.Value}");
            }

            Console.Read();
        }
    }
}
