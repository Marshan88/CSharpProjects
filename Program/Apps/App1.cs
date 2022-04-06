using System;

namespace Program.Apps
{
    internal static class App1
    {
        public static void Run(string[] args)
        {
            // B, D, A, B, B, A, A, A, B, C
            var quizManager = new QuizManager();
            quizManager.Logo();
            quizManager.Run();
            Console.Read();
        }
    }
}