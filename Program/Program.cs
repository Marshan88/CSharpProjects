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
            Console.WriteLine("What tasks do you want to run?");
            WriteTasks();
            Console.Write("Selection ");
            string taskName = Console.ReadLine();
            switch (taskName)
            {
                case "1":
                    Console.WriteLine("Task 1 starting");
                    Task1.Run(args);
                    break;                
                
                case "2":
                    Console.WriteLine("Task 2 starting");
                    Task2.Run(args);
                    break;
            }
        }

        static void WriteTasks()
        {
            Console.WriteLine("1: Task 1");
            Console.WriteLine("1: Task 2");
        }
    }
}