using System;

namespace fibonacci.Models
{
    /// <summary>
    /// Contains the result of the Fibonacci calculation.
    /// </summary>
    public class FibonacciResult
    {
        /// <summary>
        /// The index of the element to get the value from.
        /// </summary>
        public int Element { get; set; }

        /// <summary>
        /// The value of the element from the Fibonnaci sequence.
        /// </summary>
        public int Value { get; set; }
    }
}