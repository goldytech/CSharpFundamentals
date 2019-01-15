using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventSub = new EventSub(new EventPub());
            eventSub.PrintNumber();
            eventSub.PrintMoney();
            eventSub.Unsubscribe();
            eventSub.PrintMoney();
            Console.Read();
        }
    }
}
