using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class ReverseString
    {
        public static void RunThis()
        {
            string str = "Hello World";
            string reversed = "";

            // Loop through the string from the last character to the first
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];  // Append each character to the reversed string
            }

            Console.WriteLine("Reversed String: " + reversed);
        }                                                
    }    
}
