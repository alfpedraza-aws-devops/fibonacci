using System;

namespace fibonacci.Services
{
    /// <summary>
    /// Gets the nth element in the Fibonacci sequence.
    /// </summary>
    public interface IFibonacciCalculator
    {
        /// <summary>
        /// Gets the nth element in the Fibonacci sequence.
        /// </summary>
        /// <param name="element">The index of the element to get the value from.</param>
        /// <returns>The value of the nth element in the Fibonacci sequence.</returns>
        int Fibonacci(int element);
    }
}