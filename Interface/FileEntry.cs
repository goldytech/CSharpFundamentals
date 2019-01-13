using System;

namespace Interface
{
    public class FileEntry : IStoreable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to file...");
        }

        public string Read()
        {
            return "Reading note from file";
        }

        public ReturnStatus Status { get; set; }
    }
}