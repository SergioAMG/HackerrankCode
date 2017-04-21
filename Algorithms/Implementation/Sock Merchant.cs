using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);

        int counter = 0;
        List<int> socks = c.ToList();
        socks.Sort();
        for (int i = 0; i < n; i++)
        {
            if (i < socks.Count - 1)
            {
                if (socks[i] == socks[i + 1])
                {
                    socks.Remove(socks[i]);
                    socks.Remove(socks[i]);
                    counter++;
                    i = -1;
                }
            }
        }
        Console.WriteLine(counter);
    }
}