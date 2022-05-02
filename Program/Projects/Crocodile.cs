using System;


namespace Program.Projects
{
    internal static class Crocodile
    {
        public static void Run(string[] args)
        {
            var crocManager = new CrocodileManager();
            CrocodileManager.Logo();
            crocManager.Run();
            Console.Read();
        }
    }
}