using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindSecondLargestElementArray
    {
        public static void RunThis()
        {
            int[] arr = { 10, 20, 4, 45, 99 };

            int first = int.MinValue, second = int.MinValue;

            // Loop through the array to find the largest and second largest elements
            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;  // Move the largest to second
                    first = num;  // Update the largest
                }
                else if (num > second && num != first)
                {
                    second = num;  // Update the second largest
                }
            }

            Console.WriteLine("Second largest element: " + second);
        }                                                
    }    
}
