using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What task do you want to run?\n------------------");
            WriteTasks();
            Console.WriteLine("\n------------------");
            Console.Write("\nSelection: ");
            string taskName = Console.ReadLine();
            switch (taskName)
            {
                case "1":
                    Console.WriteLine("\nRunning Task 1\n------------------");
                    Task1.Run(args);
                    break;                
                
                case "2":
                    Console.WriteLine("\nRunning Task 2\n------------------");
                    Task2.Run(args);
                    break;
                case "3":
                    Console.WriteLine("\nRunning Task 3\n------------------");
                    Task3.Run(args);
                    break;
                case "4":
                    Console.WriteLine("\nRunning Task 4\n------------------");
                    Task4.Run(args);
                    break;
            }
        }

        static void WriteTasks()
        {
            Console.WriteLine("Options:\n");
            Console.WriteLine("1: Variables and assignment");
            Console.WriteLine("2: Inheritance-IN PROGRESS");
            Console.WriteLine("3: Crocodile Game");
            Console.WriteLine("4: Dank Souls");
        }
    }
}