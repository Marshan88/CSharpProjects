﻿using System;

namespace Program.Projects
{
    internal static class Project1
    {
        public static void Run(string[] args)
        {
            // B, D, A, B, B, A, A, A, B, C
            var quizManager = new QuizManager();
            QuizManager.Logo();
            quizManager.Run();
            Console.Read();
        }
    }
}