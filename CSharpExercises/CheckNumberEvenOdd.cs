using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class CheckNumberEvenOdd
    {
        public static void RunThis()
        {
            int number = 15;

            // Check if the number is divisible by 2
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
       }                                                
    }    
}
