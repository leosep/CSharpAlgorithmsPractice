using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class MergeTwoSortedArrays
    { 

        public static void RunThis()
        {
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            int[] merged = new int[arr1.Length + arr2.Length];

            int i = 0, j = 0, k = 0;

            // Merge the arrays by comparing elements from both arrays
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    merged[k++] = arr1[i++];
                }
                else
                {
                    merged[k++] = arr2[j++];
                }
            }

            // Copy remaining elements of arr1, if any
            while (i < arr1.Length)
            {
                merged[k++] = arr1[i++];
            }

            // Copy remaining elements of arr2, if any
            while (j < arr2.Length)
            {
                merged[k++] = arr2[j++];
            }

            Console.WriteLine("Merged array: " + string.Join(", ", merged));
        }                                                
    }    
}
