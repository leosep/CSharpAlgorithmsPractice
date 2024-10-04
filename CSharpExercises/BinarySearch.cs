using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class BinarySearch
    {
        public static void RunThis()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13 };  // The sorted array
            int target = 7;  // The element to search for
            int low = 0, high = arr.Length - 1;

            // Perform binary search
            while (low <= high)
            {
                int mid = (low + high) / 2;  // Find the middle index

                if (arr[mid] == target)
                {
                    // If the middle element is the target, print its index and exit
                    Console.WriteLine("Element found at index " + mid);
                    return;
                }
                else if (arr[mid] < target)
                {
                    // If target is greater, ignore the left half by adjusting 'low'
                    low = mid + 1;
                }
                else
                {
                    // If target is smaller, ignore the right half by adjusting 'high'
                    high = mid - 1;
                }
            }

            // If the target element is not found
            Console.WriteLine("Element not found");
        }                                                
    }    
}
