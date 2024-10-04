using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindSumDigits 
    { 

        public static void RunThis()
        {
        int number = 1234;
        int sum = 0;

        // Loop until all digits are processed
        while (number > 0)
        {
            sum += number % 10;  // Add the last digit to sum
            number /= 10;  // Remove the last digit from the number
        }

        Console.WriteLine("Sum of digits: " + sum);
    }                                                
    }    
}
