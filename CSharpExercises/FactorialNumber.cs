using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FactorialNumber
    {
        public static void RunThis()
        {
            int number = 5;
            int factorial = 1;

            // Calculate factorial using a for loop
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;  // Multiply the current factorial by the loop index
            }

            Console.WriteLine("Factorial of " + number + " is " + factorial);
        }                                                
    }    
}
