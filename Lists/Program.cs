using System;
using System.Collections.Generic;

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

            IList<Student> studentList = new List<Student>() {
                new Student(){ Id=1, Name="Bill"},
                new Student(){ Id=2, Name="Steve"},
                new Student(){ Id=3, Name="Ram"},
                new Student(){ Id=1, Name="Moin"}
            };

            foreach (var student in studentList)
            {
                Console.WriteLine($"Student id is {student.Id} and name is {student.Name}");
            }

            Console.Read();
        }
    }
}
