using System;

namespace fibonacci.Services
{
    /// <summary>
    /// Gets information from the current machine.
    /// </summary>
    public interface IHostInfoProvider
    {
        /// <summary>
        /// The machine's IP Address.
        /// </summary>
        string GetIpAddress();

        /// <summary>
        /// The current Coordinated Universal Time.
        /// </summary>
        string GetCurrentUTC();
    }
}