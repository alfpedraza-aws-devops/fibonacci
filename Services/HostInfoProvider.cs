using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace fibonacci.Services
{
    public class HostInfoProvider: IHostInfoProvider
    {
        public string GetIpAddress()
        {
            // Gets the list of IP addresses from this machine.
            // Then filters by IP Address type IPv4 and get the first one.
            // If the machine has more than one IP Address, they are discarded.
            // As this is going to be executed in a Docker container on a Kubernetes Pod,
            // it's reasonable to expect that only one Ip Address will be available.
            var hostName = Dns.GetHostName();
            var ipAddress = Dns
                .GetHostEntry(hostName)
                .AddressList
                .FirstOrDefault(x => 
                    x.AddressFamily == AddressFamily.InterNetwork);
            var result = ipAddress.ToString();
            return result;
        }

        public string GetCurrentUTC()
        {
            return DateTime.Now.ToString();
        }
    }
}