using System;
using System.Diagnostics;

namespace Program.Apps
{
    internal class App2
    {
        public static void Run(string[] args)
        {
            var random = new Random();
            var stopWatch = new Stopwatch();
            var crocManager = new CrocManager();
            var points = 0;
            const string logo = @"_________                                .___.__.__             ________                       
\_   ___ \_______  ____   ____  ____   __| _/|__|  |   ____    /  _____/_____    _____   ____  
/    \  \/\_  __ \/    \_/ ___\/    \ / __ | |  |  | _/ __ \  /   \  ___\__  \  /     \_/ __ \ 
\     \____|  | \(   _  )  \__(   _  ) /_/ | |  |  |_\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
 \______  /|__|   \____/ \___  >____/\____ | |__|____/\___  >  \______  (____  /__|_|  /\___  >
        \/                   \/           \/              \/          \/     \/      \/     \/" + "\n";
            Console.WriteLine(logo);
            Console.WriteLine("How to play: Type in > If first Number is bigger, < if Smaller or = when equal.\n");

            while (true)
            {
                var randomNumber1 = random.Next(1, 101);
                var randomNumber2 = random.Next(1, 101);
                Console.WriteLine(randomNumber1 + " ? " + randomNumber2);
                stopWatch.Start();
                var command = Console.ReadLine();
                var timeTaken = stopWatch.Elapsed.TotalSeconds;
                if (randomNumber1 < randomNumber2)
                {
                    points = crocManager.CheckUserInput(command, points, "<");
                    points = crocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "<");
                }
                if (randomNumber1 > randomNumber2)
                {
                    points = crocManager.CheckUserInput(command, points, ">");
                    points = crocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, ">");
                }
                if (randomNumber1 == randomNumber2)
                {
                    points = crocManager.CheckUserInput(command, points, "=");
                    points = crocManager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "=");
                }
                stopWatch.Stop();

                Console.WriteLine("\n" + timeTaken + "\n");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
    }
}