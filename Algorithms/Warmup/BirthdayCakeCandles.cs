using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, Int32.Parse);

        List<int> output = new List<int>();
        output = height.ToList();
        output.Sort();
        output.Reverse();
        int candlesCount = 0;
        foreach (int item in output)
        {
            if (item == output[0])
                candlesCount++;
        }
        Console.WriteLine(candlesCount);
    }
}
