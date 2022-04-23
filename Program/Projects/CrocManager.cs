using System;


namespace Program.Projects
{
    internal class CrocManager
    {
        public static string Logo()
        {
            const string logo = @"_________                                .___.__.__             ________                       
\_   ___ \_______  ____   ____  ____   __| _/|__|  |   ____    /  _____/_____    _____   ____  
/    \  \/\_  __ \/    \_/ ___\/    \ / __ | |  |  | _/ __ \  /   \  ___\__  \  /     \_/ __ \ 
\     \____|  | \(   _  )  \__(   _  ) /_/ | |  |  |_\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
 \______  /|__|   \____/ \___  >____/\____ | |__|____/\___  >  \______  (____  /__|_|  /\___  >
        \/                   \/           \/              \/          \/     \/      \/     \/";
            Console.WriteLine(logo + "\n");
            return logo;
        }

        public int CheckAnswerCorrect(string answer, int points, string character)
        {

            if (answer == character)
            { 
                points++;
            }
            else
            {
                points--;
            }

            return points;
        }

        public void Run()
        {
            var random = new Random();
            var points = 0;
            while (true)
            {
                var randomNumber1 = random.Next(1, 101);
                var randomNumber2 = random.Next(1, 101);
                Console.WriteLine(randomNumber1 + " ? " + randomNumber2);
                var answer = Console.ReadLine();
                if (randomNumber1 < randomNumber2)
                {
                    points = CheckAnswerCorrect(answer, points, "<");
                }

                if (randomNumber1 > randomNumber2)
                {
                    points = CheckAnswerCorrect(answer, points, ">");
                }

                if (randomNumber1 == randomNumber2)
                {
                    points = CheckAnswerCorrect(answer, points, "=");
                }

                Console.WriteLine("Your points: " + points + "\n");
            }
        }

    }
}

//var timeTaken = stopWatch.Elapsed.TotalSeconds;
//stopWatch.Start();
//stopWatch.Stop();

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
//    var answer = Console.ReadLine();
//    var timeTaken = stopWatch.Elapsed.TotalSeconds;
//    if (randomNumber1 < randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(answer, points, "<");
//        points = CrocManager.CheckUserInputTime(answer, points, stopWatch.Elapsed.TotalSeconds, "<");
//    }
//    if (randomNumber1 > randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(answer, points, ">");
//        points = CrocManager.CheckUserInputTime(answer, points, stopWatch.Elapsed.TotalSeconds, "<");
//    }
//    if (randomNumber1 == randomNumber2)
//    {
//        points = CrocManager.CheckUserInput(answer, points, "=");
//        points = CrocManager.CheckUserInputTime(answer, points, stopWatch.Elapsed.TotalSeconds, "=");
//    }
//    stopWatch.Stop();

//    Console.WriteLine("\n" + timeTaken + "\n");
//    Console.WriteLine("Your points: " + points + "\n");

//public int CheckUserInputTime(double time)
//{
//        if  (time < 1)
//        {
//            return 1;
//        }
//        return 0;
//}