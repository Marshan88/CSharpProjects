using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters;

namespace Program.Apps
{
    internal static class App2
    {
        public static void Run(string[] args)
        {
            var crocManager = new CrocManager();
            CrocManager.Logo();
            crocManager.Run();
            Console.Read();
        }
    }
}