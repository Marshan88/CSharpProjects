using System;
using Program.Projects;

namespace Program
{
    public static class ProjectView
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pick a game:\n");
                GetGameList();
                Console.Write("\n");
                var projectName = Console.ReadLine();
                switch (projectName)
                {
                    case "1":
                        Quiz.Run();
                        break;
                    case "2":
                        Crocodile.Run(args);
                        break;
                    case "3":
                        DankSouls.Run();
                        break;
                    default:
                        Console.WriteLine("Invalid input\n");
                        continue;
                }
                break;
            }
        }

        private static void GetGameList()
        {
            Console.WriteLine("1: Quiz");
            Console.WriteLine("2: Crocodile");
            Console.WriteLine("3: Dank Souls");
        }
    }
}