using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var exceptionTester = new ExceptionTester();
                exceptionTester.Method1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            Console.Read();

        }
    }
}
