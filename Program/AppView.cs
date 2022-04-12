using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Apps;

namespace Program
{
    public static class AppView
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What game do you want to play?\n");
                GetGameList();
                Console.Write("\n");
                var appName = Console.ReadLine();
                switch (appName)
                {
                    case "1":
                        Console.WriteLine("\nQuiz is running\n------------------");
                        App1.Run(args);
                        break;
                    case "2":
                        Console.WriteLine("\nCrocodile Game is running\n------------------");
                        App2.Run(args);
                        break;
                    case "3":
                        Console.WriteLine("\nDank Souls is running\n------------------");
                        App3.Run(args);
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