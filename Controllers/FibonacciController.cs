using System;
using fibonacci.Models;
using fibonacci.Services;
using Microsoft.AspNetCore.Mvc;

namespace fibonacci.Controllers
{
    /// <summary>
    /// Exposes a REST endpoint to GET the nth element in the Fibonacci sequence recursively.
    /// </summary>
    /// <remarks>
    /// This endpoint is used to generate a heavy processing load on the CPU and can be used
    /// for a machine cluster load test.
    /// </remarks>
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciController"/> class.
        /// </summary>
        /// <param name="service">A <see cref="IFibonacciService"/> object that
        /// gets the nth element in the sequence.</param>
        public FibonacciController(IFibonacciService service)
        {
            _service = service;
        }

        /// <summary>
        /// Exposes a GET endepoint to get the nth element in the sequence.
        /// </summary>
        /// <param name="element">The index of the element to get the value from.</param>
        /// <example>HTTP GET /api/fibonacci/40</example>
        [HttpGet("{element=40}")]
        public FibonacciResult Get(int element)
        {
            var result = _service.Calculate(element);
            return result;
        }
    }
}
