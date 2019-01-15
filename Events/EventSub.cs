using System;

namespace Events
{
    public class EventSub
    {
        private readonly EventPub _eventPub;

        public EventSub(EventPub eventPub)
        {
            _eventPub = eventPub;
            _eventPub.BeforePrintEvent += _eventPub_BeforePrintEvent;
        }

        private void _eventPub_BeforePrintEvent()
        {
            Console.WriteLine("Event got published by publisher and subscriber took the action on it");
        }

        public void PrintNumber()
        {
            _eventPub.PrintNumber(10);
        }

        public void PrintMoney()
        {
            _eventPub.PrintMoney(25);
        }

        public void Unsubscribe()
        {
            _eventPub.BeforePrintEvent -= _eventPub_BeforePrintEvent;
        }
    }
}