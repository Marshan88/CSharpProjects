using System;
using System.Collections.Generic;

namespace Program.Tasks
{
    public class Question
    {
        private readonly int _charStart = 65;
        private readonly string _question;
        private string _correctAnswer;
        public List<string> Answers { get; }

        public Question(string question)
        {
            _question = question;
            Answers = new List<string>();
        }

        public void SetCorrectAnswer(string correctAnswer)
        {
            _correctAnswer = correctAnswer.ToLower();
        }

        public void Print(int num)
        {
            Console.WriteLine($"Question {num}: {_question}");
            for (var i = 0; i < Answers.Count; i++)
            {
                var character = (char)(_charStart + i);
                Console.WriteLine($"{character}: {Answers[i]}");
            }
        }

        public bool CheckAnswer(string answer)
        {
            return _correctAnswer == answer.ToLower();
        }
    }
}