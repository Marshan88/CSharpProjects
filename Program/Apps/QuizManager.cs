using System;
using System.Collections.Generic;

namespace Program.Apps
{
    class QuizManager
    {        
        public string Logo()
        {
            string logo = @"________         __        
\_____  \  __ __|__|_______
 /  / \  \|  |  |  |___   /
/   \_/   \  |  |  |/ ___/ 
\_____\ \_/____/|__/_____ \
       \__>              \/";
            Console.WriteLine(logo + "\n");
            return logo;
        }

        private int _correct;
        private int _incorrect;

        public List<Question> Questions { get; }

        public QuizManager()
        {
            Questions = new List<Question>();
        }

        public void Run()
        {
            for (var i = 0; i < Questions.Count; i++)
            {
                Questions[i].Print(i + 1);
                var answer = "Your answer: " + Console.ReadLine();
                if (Questions[i].CheckAnswer(answer))
                {
                    _correct++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    _incorrect++;
                    Console.WriteLine("Wrong!");
                }
                Console.WriteLine($"Your points: {_correct - _incorrect}\n");
            }
            Console.WriteLine((int)Math.Round((double)(100 * _correct) / Questions.Count) + "% Correct");
            Console.WriteLine("Total wrong: " + _incorrect);
        }
    }
}