using System;
using System.Diagnostics;
using System.Threading;

namespace Program.Tasks
{
    internal class App1
    {
        public static void Run(string[] args)
        {
            /*
             * Example from Anders
             */

            var quizManager = new QuizManager2();

            var question = new Question("Is Marius a simp?");
            question.Answers.Add("Yes");
            question.Answers.Add("No");
            question.Answers.Add("Maybe");
            question.SetCorrectAnswer("a");
            quizManager.Questions.Add(question);

            var question2 = new Question("Is Linn a moron?");
            question2.Answers.Add("Yes");
            question2.Answers.Add("No");
            question2.Answers.Add("Maybe");
            question2.Answers.Add("FUCK YES");
            question2.SetCorrectAnswer("d");
            quizManager.Questions.Add(question2);

            quizManager.Run();

            /*
             * End example
             */

            // B, D, A, B, B, A, A, A, B, C
            var quizmanager = new QuizManager();
            quizmanager.Logo();
            int points = 0;
            int correct = 0;
            int incorrect = 0;
            int total = 10;
            string answer;

            quizmanager.Question1();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer1(answer, points, correct, incorrect);

            quizmanager.Question2();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer2(answer, points, correct, incorrect);

            quizmanager.Question3();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer3(answer, points, correct, incorrect);

            quizmanager.Question4();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer4(answer, points, correct, incorrect);

            quizmanager.Question5();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer5(answer, points, correct, incorrect);

            quizmanager.Question6();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer6(answer, points, correct, incorrect);

            quizmanager.Question7();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer7(answer, points, correct, incorrect);

            quizmanager.Question8();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer8(answer, points, correct, incorrect);

            quizmanager.Question9();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer9(answer, points, correct, incorrect);

            quizmanager.Question10();
            answer = Console.ReadLine().ToLower();
            quizmanager.Answer10(answer, points, correct, incorrect);

            quizmanager.EndStats(correct, incorrect, total);
            Console.Read();
        }
    }
}

/*
 * 
 Oppgave TriviaQuiz
------------------
Lag en quiz-app som har x antall spørsmål der brukeren kan gjette og få poeng utifra om det er gjettet riktig eller ikke.


  - I spillet:
    *Print ut spørsmål
    *Ta imot svar fra bruker 
    *Print ut om det er riktig eller galt 
  - Slutten:
    * Print ut hvor mye av x antall spørsmål i % som var besvart riktig og hvor mye poeng du fikk.

  Husk klasser :)

*/