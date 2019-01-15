using System;

namespace CustomException
{
    [Serializable]
    public class MyCustomException : Exception
    {
        public MyCustomException(string message):
            base(message)
        
        {
            
        }
    }
}
