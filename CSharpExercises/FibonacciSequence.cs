using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FibonacciSequence
    {
        public static void RunThis()
        {
            int n = 10;  // Number of Fibonacci terms to print
            int a = 0, b = 1, temp;

            Console.Write(a + " " + b + " ");  // Print first two Fibonacci numbers

            for (int i = 2; i < n; i++)
            {
                temp = a + b;  // Calculate the next Fibonacci number
                Console.Write(temp + " ");  // Print the next Fibonacci number
                a = b;  // Update a to the previous b
                b = temp;  // Update b to the current Fibonacci number
            }
        }                                                
    }    
}
