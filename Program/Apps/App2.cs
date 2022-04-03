using System;
using System.Diagnostics;
using System.Threading;

namespace Program.Apps
{
    internal class App2
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            Stopwatch stopWatch = new Stopwatch();
            var crockmanager = new CrocManager();
            int randomNumber1;
            int randomNumber2;
            int points = 0;
            string logo = @"_________                                .___.__.__             ________                       
\_   ___ \_______  ____   ____  ____   __| _/|__|  |   ____    /  _____/_____    _____   ____  
/    \  \/\_  __ \/    \_/ ___\/    \ / __ | |  |  | _/ __ \  /   \  ___\__  \  /     \_/ __ \ 
\     \____|  | \(   _  )  \__(   _  ) /_/ | |  |  |_\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
 \______  /|__|   \____/ \___  >____/\____ | |__|____/\___  >  \______  (____  /__|_|  /\___  >
        \/                   \/           \/              \/          \/     \/      \/     \/" + "\n";
            Console.WriteLine(logo);
            Console.WriteLine("How to play: Type in > If first Number is bigger, < if Smaller or = when equal.\n");

            while (true)
            {
                randomNumber1 = random.Next(1, 12);
                randomNumber2 = random.Next(1, 12);
                Console.WriteLine(randomNumber1 + " ? " + randomNumber2);
                stopWatch.Start();
                var command = Console.ReadLine();
                var timeTaken = stopWatch.Elapsed.TotalSeconds;
                if (randomNumber1 < randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, "<");
                    points = crockmanager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "<");
                }
                if (randomNumber1 > randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, ">");
                    points = crockmanager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, ">");
                }
                if (randomNumber1 == randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, "=");
                    points = crockmanager.CheckUserInputTime(command, points, stopWatch.Elapsed.TotalSeconds, "=");
                }
                stopWatch.Stop();

                Console.WriteLine("\n" + timeTaken + "\n");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
    }
}