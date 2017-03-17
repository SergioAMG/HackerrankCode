using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        long sum = 0;
        foreach (int i in arr)
        {
            sum = sum + long.Parse(i.ToString());
        }
        Console.WriteLine(sum.ToString());
    }
}