using System;
using Program.Projects;

namespace Program
{
    public static class ProjectView
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What game do you want to play?\n");
                GetGameList();
                Console.Write("\n");
                var projectName = Console.ReadLine();
                switch (projectName)
                {
                    case "1":
                        Console.WriteLine("\nQuiz is running\n------------------");
                        Project1.Run(args);
                        break;
                    case "2":
                        Console.WriteLine("\nCrocodile Game is running\n------------------");
                        Project2.Run(args);
                        break;
                    case "3":
                        Console.WriteLine("\nDank Souls is running\n------------------");
                        Project3.Run(args);
                        break;
                    default:
                        Console.WriteLine("\nInvalid input\n");
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