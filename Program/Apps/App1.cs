using System;
using System.Diagnostics;
using System.Threading;

namespace Program.Apps
{
    internal class App1
    {
        public static void Run(string[] args)
        {
            // B, D, A, B, B, A, A, A, B, C
            var quizManager = new QuizManager();
            quizManager.Logo();

            var question = new Question("Question 1: Which of the following methods is an entry point in the C# console program?");
            question.Answers.Add("public static void Program()");
            question.Answers.Add("public static void Main()");
            question.Answers.Add("public static void main()");
            question.Answers.Add("None of the above\n");
            question.SetCorrectAnswer("b");
            quizManager.Questions.Add(question);

            var question2 = new Question("Question 2: Which of the followings are value types in C#?");
            question2.Answers.Add("Int32");
            question2.Answers.Add("Double");
            question2.Answers.Add("Decimal");
            question2.Answers.Add("All of the above");
            question2.SetCorrectAnswer("d");
            quizManager.Questions.Add(question2);

            var question3 = new Question("Question 3: Which of the following is a reference type in C#?");
            question3.Answers.Add("String");
            question3.Answers.Add("Long");
            question3.Answers.Add("Boolean");
            question3.Answers.Add("None of the above");
            question3.SetCorrectAnswer("a");
            quizManager.Questions.Add(question3);

            var question4 = new Question("Question 4: What is the nullable type in C#?");
            question4.Answers.Add("It allows assignment of null to reference type");
            question4.Answers.Add("It allows assignment of null to value type");
            question4.Answers.Add("It allows assignment of null to static class");
            question4.Answers.Add("None of the above");
            question4.SetCorrectAnswer("b");
            quizManager.Questions.Add(question4);

            var question5 = new Question("Question 5: Struct is a _____");
            question5.Answers.Add("Reference type");
            question5.Answers.Add("Value type");
            question5.Answers.Add("Class type");
            question5.Answers.Add("String type");
            question5.SetCorrectAnswer("b");
            quizManager.Questions.Add(question5);

            var question6 = new Question("Question 6: 10 > 9 ? '10 is greater than 9' : '9 is greater than 10' is an example of _____");
            question6.Answers.Add("Ternary operator");
            question6.Answers.Add("Conditional operator");
            question6.Answers.Add("Greater than operator");
            question6.Answers.Add("Inverse operator");
            question6.SetCorrectAnswer("a");
            quizManager.Questions.Add(question6);

            var question7 = new Question("Question 7: Which of the following datatype can be used with enum?");
            question7.Answers.Add("Int");
            question7.Answers.Add("String");
            question7.Answers.Add("Boolean");
            question7.Answers.Add("All of the above");
            question7.SetCorrectAnswer("a");
            quizManager.Questions.Add(question7);

            var question8 = new Question("Question 8: What is an indexer?");
            question8.Answers.Add("It allows an instance of a class to be indexed like an array");
            question8.Answers.Add("It allows enumerator with class");
            question8.Answers.Add("It creates index for instances of a class");
            question8.Answers.Add("None of the above");
            question8.SetCorrectAnswer("a");
            quizManager.Questions.Add(question8);

            var question9 = new Question("Question 9: String is _____");
            question9.Answers.Add("Mutable");
            question9.Answers.Add("Inmutable");
            question9.Answers.Add("Static");
            question9.Answers.Add("Value type");
            question9.SetCorrectAnswer("b");
            quizManager.Questions.Add(question9);

            var question10 = new Question("Question 10: All arrays start with _____ index");
            question10.Answers.Add("1");
            question10.Answers.Add("0");
            question10.Answers.Add("-1");
            question10.Answers.Add("0.0");
            question10.SetCorrectAnswer("b");
            quizManager.Questions.Add(question10);

            quizManager.Run();
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

// B, D, A, B, B, A, A, A, B, C
//var quizmanager = new QuizManager2();
//quizmanager.Logo();
//int points = 0;
//int correct = 0;
//int incorrect = 0;
//int total = 10;
//string answer;

//quizmanager.Question1();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer1(answer, points, correct, incorrect);

//quizmanager.Question2();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer2(answer, points, correct, incorrect);

//quizmanager.Question3();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer3(answer, points, correct, incorrect);

//quizmanager.Question4();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer4(answer, points, correct, incorrect);

//quizmanager.Question5();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer5(answer, points, correct, incorrect);

//quizmanager.Question6();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer6(answer, points, correct, incorrect);

//quizmanager.Question7();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer7(answer, points, correct, incorrect);

//quizmanager.Question8();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer8(answer, points, correct, incorrect);

//quizmanager.Question9();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer9(answer, points, correct, incorrect);

//quizmanager.Question10();
//answer = Console.ReadLine().ToLower();
//quizmanager.Answer10(answer, points, correct, incorrect);

//quizmanager.EndStats(correct, incorrect, total);