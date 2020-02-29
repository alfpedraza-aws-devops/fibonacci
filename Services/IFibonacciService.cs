using System;
using fibonacci.Models;

namespace fibonacci.Services
{
    /// <summary>
    /// Gets the nth element in the Fibonacci sequence.
    /// </summary>
    public interface IFibonacciService
    {
        /// <summary>
        /// Gets the nth element in the Fibonacci sequence.
        /// </summary>
        /// <param name="element">The index of the element to get the value from.</param>
        /// <returns>An object containing the calculation.</returns>
        FibonacciResult Calculate(int element);
    }
}