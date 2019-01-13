using System;

namespace Exceptions
{
    public class ExceptionTester
    {

        public void Method1()
        {
            Console.WriteLine("Method 1 begins");
            Method2();
            Console.WriteLine("Method 1 ends");
        }

        public void Method2()
        {

            try
            {
                Console.WriteLine("Method 2 begins");

                Method3();
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Method 2 ends");
            }




        }

        public void Method3()
        {
            Console.WriteLine("Method 3 begins");
            Console.WriteLine("File opened...");
            try
            {
                var x = 0;
                var y = 12 / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("File closed...");
            }
            Console.WriteLine("Method 3 ends");
        }

    }

}