using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindLargestElementArray
    {
        public static void RunThis()
        {
            int[] arr = { 10, 20, 4, 45, 99 };

            // Initialize two variables to hold the largest and second largest elements
            int first = int.MinValue, second = int.MinValue;

            // Traverse the array to find the largest and second largest elements
            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;  // Update second largest before updating first
                    first = num;  // Update largest element
                }
                else if (num > second && num != first)
                {
                    second = num;  // Update second largest element
                }
            }

            Console.WriteLine("Second largest element: " + second);
        }                                                
    }    
}
