using System;

namespace fibonacci.Services
{
    public class RecursiveFibonacciCalculator : IFibonacciCalculator
    {
        public int Fibonacci(int element)
        {
            if (element <= 1)
                return element;
            return Fibonacci(element - 1) + Fibonacci(element - 2);
        }
    }
}