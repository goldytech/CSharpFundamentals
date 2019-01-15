using System;

namespace Events
{
    public class EventPub
    {
        public delegate void BeforePrint();

        //declare event of type delegate
        public event BeforePrint BeforePrintEvent;

        protected virtual void OnBeforePrintEvent()
        {
            BeforePrintEvent?.Invoke();
        }

        public void PrintNumber(int num)
        {
            //call delegate method before going to print
          OnBeforePrintEvent();

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            OnBeforePrintEvent();

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            OnBeforePrintEvent();

            Console.WriteLine("Money: {0:C}", money);
        }
    }
}