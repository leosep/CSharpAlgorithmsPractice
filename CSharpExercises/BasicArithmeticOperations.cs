using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class BasicArithmeticOperations
    {
        public static void RunThis()
        {
            // Declare two integer variables and assign values
            int num1 = 10;
            int num2 = 5;

            // Perform basic arithmetic operations and print the results
            Console.WriteLine("Sum: " + (num1 + num2));  // Adds num1 and num2
            Console.WriteLine("Difference: " + (num1 - num2));  // Subtracts num2 from num1
            Console.WriteLine("Product: " + (num1* num2));  // Multiplies num1 and num2
            Console.WriteLine("Quotient: " + (num1 / num2));  // Divides num1 by num2
       }                                                
    }    
}
