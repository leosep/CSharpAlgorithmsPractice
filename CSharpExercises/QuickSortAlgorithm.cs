using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class QuickSortAlgorithm
    {
        public static void RunThis()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);  // pi is the partitioning index

                QuickSort(arr, low, pi - 1);  // Recursively sort elements before partition
                QuickSort(arr, pi + 1, high);  // Recursively sort elements after partition
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];  // Choosing the last element as the pivot
            int i = low - 1;

            // Rearrange elements based on the pivot
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);  // Place pivot in its correct position
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }    
}
