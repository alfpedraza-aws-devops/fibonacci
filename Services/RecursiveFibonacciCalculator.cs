using System;

namespace fibonacci.Services
{
    /// <summary>
    /// Gets the nth element in the Fibonacci sequence recursively.
    /// </summary>
    public class RecursiveFibonacciCalculator : IFibonacciCalculator
    {
        /// <summary>
        /// Gets the nth element in the Fibonacci sequence.
        /// </summary>
        /// <param name="element">The index of the element to get the value from.</param>
        /// <returns>The value of the nth element in the Fibonacci sequence.</returns>
        public int Fibonacci(int element)
        {
            if (element <= 1)
                return element;
            return Fibonacci(element - 1) + Fibonacci(element - 2);
        }
    }
}