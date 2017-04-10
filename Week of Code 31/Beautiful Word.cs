using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{ 
    static void Main(String[] args)
    {
        // Beautiful Word
        // Print 'Yes' if the word is beautiful or 'No' if it is not.
        
        string w = Console.ReadLine();
        char[] vowels = { 'a','e','i','o','u', 'y' };
        bool result = false;

        for (int i = 0; i < w.Length -1; i++)
        {
            // If there is a vowel in the given word ...
            // First validation 
            if (vowels.Contains(w[i]))
            {
                // Check for more consecutive vowels
                if (vowels.Contains(w[i + 1]))
                {
                    result = false;
                    break; // Improve speed by remove unnessesary code
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                // If is a consonant perform single validation
                // Second validation
                if (w[i] != w[i + 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break; // Improve speed by remove unnessesary code
                }
            }
        }

        Console.WriteLine((result) ? "Yes": "No");
    }
}
