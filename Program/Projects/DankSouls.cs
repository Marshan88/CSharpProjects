using System;

namespace Program.Projects
{
    internal static class DankSouls
    {
        public static void Run()
        {
            var dankSoulsManager = new DankSoulsManager();
            DankSoulsManager.Logo();
            dankSoulsManager.Run();
            Console.Read();
        }
    }
}