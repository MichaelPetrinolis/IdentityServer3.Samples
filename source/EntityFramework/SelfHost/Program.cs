﻿using Microsoft.Owin.Hosting;
using System;
using IdentityServer3.Core.Logging;
using Serilog;

namespace SelfHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "IdentityServer3 -- EntityFramework";
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Trace()
               .CreateLogger();

            const string url = "https://localhost:44333/core";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("\n\nServer listening at {0}. Press enter to stop", url);
                Console.ReadLine();
            }
        }
    }
}