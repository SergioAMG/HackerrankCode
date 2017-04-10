using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        // your code goes here
        
        // Group the birds by using a list and then sort the list for finding the max value
        List<int> birdsList = types.ToList();
        var groupedList = birdsList.GroupBy(i => i).OrderByDescending(i => i.Key).ToList();

        // Creates a new list of KeyValuePairs for managing the count per group and use the number for sorting
        List<KeyValuePair<int, int>> flock = new List<KeyValuePair<int, int>>();       
        foreach (var val in groupedList)
        {
            KeyValuePair<int, int> item = new KeyValuePair<int, int>(val.Key, val.Count());
            flock.Add(item);
        }
        flock = flock.OrderBy(i => i.Value).ToList();
        flock.Reverse();
        
        // Result
        Console.WriteLine(flock[0].Key);
    }   
}
