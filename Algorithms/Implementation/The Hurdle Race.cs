using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, Int32.Parse);
        // your code goes here
        int magicBeveragesConsumed = 0;
        foreach (int hurdle in height)
        {
            if (k < hurdle)
            {
                while (k < hurdle)
                {
                    k++;
                    magicBeveragesConsumed++;
                    if (k >= hurdle)
                        break;
                }
            }
        }
        Console.WriteLine(magicBeveragesConsumed);
    }
}
