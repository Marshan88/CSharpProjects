using System;
using System.Diagnostics;

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

//var random = new Random();
//var stopWatch = new Stopwatch();
//var points = 0;
//CrocManager.Logo();
//Console.WriteLine("How to play: Type in > If first Number is bigger, < if Smaller or = when equal.\n");

//while (true)
//{
//    var randomNumber1 = random.Next(1, 101);
//    var randomNumber2 = random.Next(1, 101);
//    Console.WriteLine(randomNumber1 + " ? " + randomNumber2);
//    stopWatch.Start();
//    var command = Console.ReadLine();
//    var timeTaken = stopWatch.Elapsed.TotalSeconds;
//    if (randomNumber1 < randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(command, points, "<");
//        points = CrocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "<");
//    }
//    if (randomNumber1 > randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(command, points, ">");
//        points = CrocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, ">");
//    }
//    if (randomNumber1 == randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(command, points, "=");
//        points = CrocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "=");
//    }
//    stopWatch.Stop();

//    Console.WriteLine("\n" + timeTaken + "\n");
//    Console.WriteLine("Your points: " + points + "\n");