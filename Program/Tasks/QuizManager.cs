using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tasks
{
    class QuizManager {
        private int _points = 0;
        private int _correct = 0;
        private int _incorrect = 0;
        //readonly int total = 10;
        //readonly string answer;

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
        public void Question1()
        {
            Console.WriteLine("Question 1: Which of the following methods is an entry point in the C# console program?");
            Console.WriteLine("A: public static void Program()");
            Console.WriteLine("C: public static void Main()");
            Console.WriteLine("B: public static void main()");
            Console.WriteLine("D: None of the above\n");
        }

        public void Answer(string answer)
        {
            if (answer == "b")
            {
                _points++;
                _correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + _points + "\n");
            }
            else
            {
                _incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + _points + "\n");
            }
        }
        public void Question2()
        {
            Console.WriteLine("Question 2: Which of the followings are value types in C#?");
            Console.WriteLine("A: Int32.)");
            Console.WriteLine("B: Double.");
            Console.WriteLine("C: Decimal.");
            Console.WriteLine("D: All of the above");
        }

        public void Answer2(string answer, int points, int correct, int incorrect)
        {
            if (answer == "d")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question3()
        {
            Console.WriteLine("Question 3: Which of the following is a reference type in C#?");
            Console.WriteLine("A: String.)");
            Console.WriteLine("B: Long.");
            Console.WriteLine("C: Boolean.");
            Console.WriteLine("D: None of the above.");
        }

        public void Answer3(string answer, int points, int correct, int incorrect)
        {
            if (answer == "a")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question4()
        {
            Console.WriteLine("Question 4: What is the nullable type in C#?");
            Console.WriteLine("A: It allows assignment of null to reference type.)");
            Console.WriteLine("B: It allows assignment of null to value type.");
            Console.WriteLine("C: It allows assignment of null to static class.");
            Console.WriteLine("D: None of the above.");
        }

        public void Answer4(string answer, int points, int correct, int incorrect)
        {
            if (answer == "b")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question5()
        {
            Console.WriteLine("Question 5: Struct is a _____.");
            Console.WriteLine("A: Reference type)");
            Console.WriteLine("B: Value type");
            Console.WriteLine("C: Class type");
            Console.WriteLine("D: String type");
        }

        public void Answer5(string answer, int points, int correct, int incorrect)
        {
            if (answer == "b")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question6()
        {
            Console.WriteLine("Question 6: 10 > 9 ? '10 is greater than 9' : '9 is greater than 10' is an example of _____");
            Console.WriteLine("A: Ternary operator)");
            Console.WriteLine("B: Conditional operator");
            Console.WriteLine("C: Greater than operator");
            Console.WriteLine("D: Inverse operator");
        }

        public void Answer6(string answer, int points, int correct, int incorrect)
        {
            if (answer == "a")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question7()
        {
            Console.WriteLine("Question 7: Which of the following datatype can be used with enum?");
            Console.WriteLine("A: Int)");
            Console.WriteLine("B: String");
            Console.WriteLine("C: Boolean");
            Console.WriteLine("D: All of the above");
        }

        public void Answer7(string answer, int points, int correct, int incorrect)
        {
            if (answer == "a")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question8()
        {
            Console.WriteLine("Question 8: What is an indexer?");
            Console.WriteLine("A: It allows an instance of a class to be indexed like an array)");
            Console.WriteLine("B: It allows enumerator with class");
            Console.WriteLine("C: It creates index for instances of a class");
            Console.WriteLine("D: None of the above");
        }

        public void Answer8(string answer, int points, int correct, int incorrect)
        {
            if (answer == "a")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question9()
        {
            Console.WriteLine("Question 9: String is _____.");
            Console.WriteLine("A: Mutable)");
            Console.WriteLine("B: Inmutable");
            Console.WriteLine("C: Static");
            Console.WriteLine("D: Value type");
        }

        public void Answer9(string answer, int points, int correct, int incorrect)
        {
            if (answer == "b")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }
        public void Question10()
        {
            Console.WriteLine("Question 10: All arrays start with _____ index.");
            Console.WriteLine("A: 1)");
            Console.WriteLine("B: 0");
            Console.WriteLine("C: -1");
            Console.WriteLine("D: 0.0");
        }

        public void Answer10(string answer, int points, int correct, int incorrect)
        {
            if (answer == "b")
            {
                points++;
                correct++;
                Console.WriteLine("Correct!");
                Console.WriteLine("Your points: " + points + "\n");
            }
            else
            {
                incorrect++;
                Console.WriteLine("Wrong answer");
                Console.WriteLine("Your points: " + points + "\n");
            }
        }

        public void EndStats(int correct, int total, int incorrect)
        {
            Console.WriteLine((int)Math.Round((double)(100 * correct) / total) + "% Correct");
            Console.WriteLine("Total wrong: " + incorrect);
        }
    }
}
