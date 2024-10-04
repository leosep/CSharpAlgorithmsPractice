using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class FindLongestWordString
    {
        public static void RunThis()
        {
            string sentence = "This is a sample sentence to find the longest word";
            string[] words = sentence.Split(' ');  // Split the sentence into words

            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;  // Update longestWord if the current word is longer
                }
            }

            Console.WriteLine("Longest word: " + longestWord);
        }                                                
    }    
}
