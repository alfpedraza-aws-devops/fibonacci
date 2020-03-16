using System;
using fibonacci.Models;

namespace fibonacci.Services
{
    /// <summary>
    /// Gets the nth element in the Fibonacci sequence.
    /// </summary>
    public class FibonacciService : IFibonacciService
    {
        private readonly IFibonacciCalculator _calculator;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciService"/> class.
        /// </summary>
        /// <param name="calculator">A <see cref="IFibonacciCalculator"/> object that
        /// calculates the nth element in the Fibonacci sequence.</param>
        public FibonacciService(IFibonacciCalculator calculator)
        {
            _calculator = calculator;
        }

        /// <summary>
        /// Gets the nth element in the Fibonacci sequence.
        /// </summary>
        /// <param name="element">The index of the element to get the value from.</param>
        /// <returns>The value of the nth element in the Fibonacci sequence.</returns>
        public FibonacciResult Calculate(int element)
        {
            var value = _calculator.Fibonacci(element);
            var result = new FibonacciResult();
            result.Element = element;
            result.Value = value;
            return result;
        }
    }
}