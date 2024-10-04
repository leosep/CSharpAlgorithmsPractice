using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindMissingNumberSequence
    {
        public static void RunThis()
        {
            int[] arr = { 1, 2, 3, 5 };
            int n = arr.Length + 1;  // The actual length of the sequence

            int expectedSum = n * (n + 1) / 2;  // Sum of first 'n' natural numbers
            int actualSum = 0;

            // Calculate the actual sum of elements in the array
            foreach (int num in arr)
            {
                actualSum += num;
            }

            int missingNumber = expectedSum - actualSum;  // The missing number
            Console.WriteLine("Missing number: " + missingNumber);
        }                                                
    }    
}
