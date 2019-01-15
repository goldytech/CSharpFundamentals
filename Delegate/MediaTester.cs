using System;

namespace Delegate
{
    public class MediaTester
    {
        public delegate int TestMedia();

        public void RunTest(TestMedia testDelegate)
        {
            var result = testDelegate();
            Console.WriteLine(result == 0 ? "Works!" : "Failed.");
        }
        //Modern way to declare the delegate
        public void RunTest(Func<int> delFunc)
        {
            var result = delFunc();
            Console.WriteLine(result == 0 ? "Works!" : "Failed.");
        }
    }
}