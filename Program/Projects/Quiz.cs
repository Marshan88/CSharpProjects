using System;

namespace Program.Projects
{
    internal static class Quiz
    {
        public static void Run()
        {
            // B, D, A, B, B, A, A, A, B, C
            var quizManager = new QuizManager();
            QuizManager.Logo();
            quizManager.Run();
            Console.Read();
        }
    }
}