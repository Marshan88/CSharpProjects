using System;

namespace Program.Tasks
{
    internal class Task3
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            var crockmanager = new CrocManager();
            int randomNumber1 = 0;
            int randomNumber2 = 0;
            int points = 0;

            //static void showText(string text)
            //{
            //    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            //}
            showText("_.-*CrocodileGame*-._\n");
            showText("How to play: > (If first Number is bigger) < (Smaller)  or  =  (numbers are equal)\n");

            while (true)
            {
                randomNumber1 = random.Next(1, 12);
                randomNumber2 = random.Next(1, 12);
                showText(randomNumber1 + " ? " + randomNumber2);
                var command = Console.ReadLine();
                if (randomNumber1 < randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, "<");
                }
                if (randomNumber1 > randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, ">");
                }
                if (randomNumber1 == randomNumber2)
                {
                    points = crockmanager.CheckUserInput(command, points, "=");
                }

                showText("Your points: " + points + "\n");

            }
        }
        static void showText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }
    }
}