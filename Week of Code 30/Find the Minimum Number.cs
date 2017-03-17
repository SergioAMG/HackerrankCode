using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string minConverted = "min(int, int)";
        string initialString = "min(int, ";
        string finalString = "int)";
        string currentString = string.Empty;

        // Break if the initial case is reached
        if (n == 2)
        {
            Console.WriteLine(minConverted);
        }
        else
        {
            // Concatenate the corresponding string after the cycle iterations
            int iCounter = 0;
            for (int i = 2; i <= n; i++)
            {
                currentString += initialString;
                iCounter++;
            }
            currentString += finalString;

            // Add the closing statment according the nummber of iterations
            for (int u=0; u< iCounter-1; u++)
            {
                currentString += ")";
            }

            Console.WriteLine(currentString);
        }

        Console.ReadKey(); // wait
    }
}
