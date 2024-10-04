using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class ReverseArrayWithoutUsingExtraSpace
    { 

        public static void RunThis()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int start = 0, end = arr.Length - 1;

            // Swap the elements from start to end
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            Console.WriteLine("Reversed array: " + string.Join(", ", arr));
        }                                                
    }    
}
