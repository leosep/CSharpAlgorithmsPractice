using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class InsertionSortAlgorithm
    {
        public static void RunThis()
        {
            int[] arr = { 12, 11, 13, 5, 6 };

            // Loop through each element in the array
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];  // The element to be inserted in the sorted part
                int j = i - 1;

                // Move elements that are greater than key to one position ahead
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;  // Place key in the correct location
            }

            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }                                                
    }    
}
