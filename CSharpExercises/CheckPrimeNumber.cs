using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class CheckPrimeNumber
    {
        public static void RunThis()
        {
            int number = 29;
            bool isPrime = true;

            // Check divisibility of number by all integers from 2 to number/2
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;  // If divisible by i, it's not a prime number
                    break;
                }
            }

            // Output whether the number is prime or not
            if (isPrime)
            {
                Console.WriteLine(number + " is Prime");
            }
            else
            {
                Console.WriteLine(number + " is not Prime");
            }
        }                                                
    }    
}
