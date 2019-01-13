using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var storableObjects = new List<IStoreable>();
            var myfile = new FileEntry();
            storableObjects.Add(myfile);
            var dbEntry = new DbEntry();
            storableObjects.Add(dbEntry);
            dbEntry = new DbEntry();
            storableObjects.Add(dbEntry);
            myfile = new FileEntry();
            storableObjects.Add(myfile);
            myfile = new FileEntry();
            storableObjects.Add(myfile);

            foreach (var storable in storableObjects)
            {
                storable.Write(null);
                Console.WriteLine(storable.Read());

            }

            Console.Read();
        }
    }
}
