using System;
using System.Collections.Generic;

namespace Program.Projects
{
    internal class QuizManager
    {
        public static string Logo()
        {
            const string logo = @"________         __        
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

        private List<Question> Questions { get; }

        public QuizManager()
        {
            Questions = AddQuestionsAndAnswers();
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
                    Console.WriteLine("\nCorrect!");
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

        private static List<Question> AddQuestionsAndAnswers()
        {   // B, D, A, B, A, A, A, A, B, C
            var quizQuestionList = new List<Question>()
            {
                new Question("Question 1: Which of the following methods is an entry point in the C# console program?",
                    "B", new List<string>()
                    {
                        "public static void Program()",
                        "public static void Main()",
                        "public static void main()",
                        "None of the above\n"
                    }),
                new Question("Question 2: Which of the followings are value types in C#?",
                    "D", new List<string>()
                    {
                        "Int32",
                        "Double",
                        "Decimal",
                        "All of the above"
                    }),
                new Question("Question 3: Which of the following is a reference type in C#?",
                    "A", new List<string>()
                    {
                        "String",
                        "Long",
                        "Boolean",
                        "None of the above"
                    }),
                new Question("Question 4: What is the nullable type in C#?",
                    "B", new List<string>()
                    {
                        "It allows assignment of null to reference type",
                        "It allows assignment of null to value type",
                        "It allows assignment of null to static class",
                        "None of the above"
                    }),
                new Question("Question 5: Struct is a _____",
                    "A", new List<string>()
                    {
                        "Reference type",
                        "Value type",
                        "Class type",
                        "String type"
                    }),
                new Question("Question 6: 10 > 9 ? '10 is greater than 9' : '9 is greater than 10' is an example of _____",
                    "A", new List<string>()
                    {
                        "Ternary operator",
                        "Conditional operator",
                        "Greater than operator",
                        "Inverse operator"
                    }),
                new Question("Question 7: Which of the following data type can be used with enum?",
                    "A", new List<string>()
                    {
                        "Int",
                        "String",
                        "Boolean",
                        "All of the above"
                    }),
                new Question("Question 8: What is an indexer?",
                    "A", new List<string>()
                    {
                        "It allows an instance of a class to be indexed like an array",
                        "It allows enumerator with class",
                        "It creates index for instances of a class",
                        "None of the above"
                    }),
                new Question("Question 9: String is _____",
                    "B", new List<string>()
                    {
                        "Mutable",
                        "Inmutable",
                        "Static",
                        "Value type"
                    }),
                new Question("Question 10: All arrays start with _____ index",
                    "C", new List<string>()
                    {
                        "1",
                        "0",
                        "-1",
                        "0.0"
                    }),
            };

            return quizQuestionList;
        }
    }
}