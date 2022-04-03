using System;
using System.Collections.Generic;

namespace Program.Tasks
{
    public class QuizManager2
    {
        private int _correct;
        private int _incorrect;

        public List<Question> Questions { get; }

        public QuizManager2()
        {
            Questions = new List<Question>();
        }

        public void Run()
        {
            for (var i = 0; i < Questions.Count; i++)
            {
                Questions[i].Print(i + 1);
                var answer = Console.ReadLine();
                if (Questions[i].CheckAnswer(answer))
                {
                    _correct++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    _incorrect++;
                    Console.WriteLine("Wrong answer");
                }
                Console.WriteLine($"Your points: {_correct - _incorrect}\n");
            }
            Console.WriteLine((int)Math.Round((double)(100 * _correct) / Questions.Count) + "% Correct");
            Console.WriteLine("Total wrong: " + _incorrect);
        }
    }
}