using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class BubbleSortAlgorithm
    {
        public static void RunThis()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };

            // Outer loop for each element
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Inner loop for comparing adjacent elements
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap elements if they are in the wrong order
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Print sorted array
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }                                                
    }    
}
