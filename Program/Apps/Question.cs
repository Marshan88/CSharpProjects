using System;
using System.Collections.Generic;

namespace Program.Apps
{
    public class Question
    {
        private const int CharStart = 65;
        private readonly string _question;
        private string _correctAnswer;
        private List<string> Answers { get; }
        
        public Question(string question, string correctAnswer, List<string> answers)
        {
            _question = question;
            Answers = answers;
            SetCorrectAnswer(correctAnswer);
        }

        private void SetCorrectAnswer(string correctAnswer)
        {
            _correctAnswer = correctAnswer.ToLower();
        }

        public void Print(int num)
        {
            Console.WriteLine($"Question {num}: {_question}");
            for (var i = 0; i < Answers.Count; i++)
            {
                var character = (char)(CharStart + i);
                Console.WriteLine($"{character}: {Answers[i]}");
            }
        }

        public bool CheckAnswer(string answer)
        {
            return _correctAnswer == answer.ToLower();
        }
    }
}