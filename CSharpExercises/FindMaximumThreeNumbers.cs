using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindMaximumThreeNumbers
    {
        public static void RunThis()
        {
            int num1 = 10, num2 = 20, num3 = 15;

            // Use nested if statements to find the largest number
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Max: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Max: " + num2);
            }
            else
            {
                Console.WriteLine("Max: " + num3);
            }
        }                                                
    }    
}
