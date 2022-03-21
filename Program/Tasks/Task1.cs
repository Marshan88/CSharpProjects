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
            /*int intVar = 0;                        - 4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647.
            string stringVar = "Hello, World!";      - 2 bytes per character	Stores a sequence of characters, surrounded by double quotes.
            bool boolVar = true;                     - 1 bit	Stores true or false values.
            char charVar = 'A';                      - 2 bytes	Stores a single character/letter, surrounded by single quotes.
            float floatVar = 3.14f;  	             - 4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
            long longVar = 4153135l;                 - 8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            double doubleVar = 31.21d;               - 8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits.
            decimal decimalVar = 3.01M;              - 16 bytes Because the decimal type has more precision and a smaller range than both float and double, it is appropriate for financial and monetary calculations.
            
Use float, double or decimal?

The precision of a floating point value indicates how many digits the value can have after the decimal point.
The precision of float is only six or seven decimal digits,
            
while double variables have a precision of about 15 digits.
Therefore it is safer to use double for most calculations.

Because the decimal type has more precision and a smaller range than both float and double,
it is appropriate for financial and monetary calculations. */


            Console.WriteLine("\nSub task 1.\n\nWhat is the sum total:\nvar a = 5\nVar = b 3.0M\nvar sum = a + b\n");
            var a = 5;
            var b = 3.0M;
            var sum = a + b;           //SVAR: decimal
            Console.WriteLine("Answer: " + sum + "\n");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Sub task 2\n\nWhat type of variable is sum:\nAnswer: decimal\n");
            Console.ReadLine();
        }
    }
}
