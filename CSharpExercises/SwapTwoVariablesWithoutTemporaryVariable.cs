using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class SwapTwoVariablesWithoutTemporaryVariable
    { 

        public static void RunThis()
        {
            int a = 5, b = 10;

            // Swap the values using arithmetic operations
            a = a + b;  // a becomes 15
            b = a - b;  // b becomes 5 (original value of a)
            a = a - b;  // a becomes 10 (original value of b)

            Console.WriteLine("After Swap: a = " + a + ", b = " + b);
        }                                                
    }    
}
