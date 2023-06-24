using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    //Take a user input word and reverse it using loop.
    public class ReverseWord
    {
        public static string reverseWord(string word)
        {
            char[] characters = word.ToCharArray();

            int leftIndex = 0;
            int rightIndex = characters.Length - 1;

            while (leftIndex < rightIndex)
            {
                // Swap characters at left and right indices
                char temp = characters[leftIndex];
                characters[leftIndex] = characters[rightIndex];
                characters[rightIndex] = temp;

                // Move the indices towards the center
                leftIndex++;
                rightIndex--;
            }

            return new string(characters);
        }
    }
}
