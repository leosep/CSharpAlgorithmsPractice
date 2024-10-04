using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindDuplicatesArray
    {
        public static void RunThis()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 3, 2, 7, 8 };
            HashSet<int> seen = new HashSet<int>();  // Store unique elements
            HashSet<int> duplicates = new HashSet<int>();  // Store duplicate elements

            // Traverse the array to find duplicates
            foreach (int num in arr)
            {
                if (!seen.Add(num))  // Add num to seen and check if it's already present
                {
                    duplicates.Add(num);  // If num is already in seen, it's a duplicate
                }
            }

            Console.WriteLine("Duplicate elements: " + string.Join(", ", duplicates));
        }                                                
    }    
}
