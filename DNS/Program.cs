using System;
using System.Net;

namespace MyHostName
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostName = Dns.GetHostName();
            Console.WriteLine($"Hostname: {hostName}");
        }
    }
}

