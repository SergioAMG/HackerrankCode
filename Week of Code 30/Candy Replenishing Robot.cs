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
        string[] tokens_n = Console.ReadLine().Split(' ');

        // Descriptive variables names
        int candies = Convert.ToInt32(tokens_n[0]);
        int times = Convert.ToInt32(tokens_n[1]);
        string[] temp = Console.ReadLine().Split(' ');
        int[] candyRemove = Array.ConvertAll(temp, Int32.Parse);
        int candiesLeft = candies;
        int diffAdded = 0;

        // Main loop for times
        for (int i = 0; i < times; i++)
        {
            // Remove candies
            candiesLeft = candiesLeft - candyRemove[i];

            // First rule validation candiesLeft < 5 then add (candies - candiesLeft)
            if (candiesLeft < 5 && i < times - 1)
            {
                diffAdded += (candies - candiesLeft);
                candiesLeft = candiesLeft + (candies - candiesLeft);
            }
        }

        // Spit the ouput answer
        Console.WriteLine(diffAdded);
        Console.ReadKey();
    }
}
