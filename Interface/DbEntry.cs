using System;

namespace Interface
{
    public class DbEntry : IStoreable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to database...");
        }

        public string Read()
        {
            return "Reading entry from database";
        }

        public ReturnStatus Status { get; set; }
    }
}