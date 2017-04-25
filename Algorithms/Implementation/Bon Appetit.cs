using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens[0]);
        int k = Convert.ToInt32(tokens[1]);
        string[] priceTokens = Console.ReadLine().Split(' ');
        int[] prices = Array.ConvertAll(priceTokens, Int32.Parse);
        int charge = Convert.ToInt32(Console.ReadLine());
        int check = 0;
        for (int i = 0; i < n; i++)
        {
            if (i != k)
            {
                check += prices[i];
            }
        }
        int difference = (check / 2) - charge;
        if (difference == 0)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(Math.Abs(difference));
        }
    }
}
