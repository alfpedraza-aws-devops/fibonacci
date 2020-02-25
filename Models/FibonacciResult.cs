using System;

namespace fibonacci.Models
{
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

        /// <summary>
        /// Contains the Host IP Address and current UTC time.
        /// </summary>
        public string Metadata { get; set; }
    }
}