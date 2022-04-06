using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Apps;

namespace Program
{
    public class AppView
    {
        static void Main(string[] args)
        {
            Console.WriteLine("which app do you want to run?\n");
            WriteTasks();
            Console.Write("\nApp nr: ");
            string appName = Console.ReadLine();
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
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Try again\n");
                    Main(args);
                    break;
            }
        }

        static void WriteTasks()
        {
            Console.WriteLine("1: Quiz");
            Console.WriteLine("2: Crocodile Game");
            Console.WriteLine("3: Dank Souls");
        }
    }
}