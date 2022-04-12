using System;


namespace Program.Projects
{
    internal static class Project2
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