using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tasks
{
    public class Task1
    {
        public static void Run(string[] args)
        {
            /*int intVar = 0;
            string stringVar = "Hello, World!";
            bool boolVar = true;
            char charVar = 'A';
            float floatVar = 3.14f;
            long longVar = 4153135l;
            decimal decimalVar = 3.01M;  
            double doubleVar = 31.21d;*/

            var a = 5;
            var b = 3.0M;
            var sum = a + b;           //SVAR: Decimal

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
