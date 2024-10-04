using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class SelectionSortAlgorithm
    {
        public static void RunThis()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            // One by one, move the boundary of the unsorted subarray
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;  // Assume the first element is the minimum

                // Find the minimum element in the unsorted part
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;  // Update minIdx if a smaller element is found
                    }
                }

                // Swap the found minimum element with the first element
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }

            // Print sorted array
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }                                                
    }    
}
