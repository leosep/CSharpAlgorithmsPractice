using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class CheckNumberArmstrong
    {
        public static void RunThis()
        {
            int number = 153;
            int temp = number;
            int sum = 0;

            // Calculate the sum of the cubes of the digits
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }

            // Check if the sum equals the original number
            if (sum == number)
            {
                Console.WriteLine(number + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number");
            }
        }                                                
    }    
}
