using System;

namespace CustomException
{
    public class ExceptionTester
    {
        public int DoDivide(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            if (x == 0)
                throw new MyCustomException("Dividend can't be zero!");
            return x / y;
        }
    }
}