using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class PalindromeCheck
    {
        public static void RunThis()
        {
            string str = "madam";
            bool isPalindrome = true;

            // Compare characters from the start and end
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;  // If characters don't match, it's not a palindrome
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(str + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a Palindrome");
            }
        }                                                
    }    
}
