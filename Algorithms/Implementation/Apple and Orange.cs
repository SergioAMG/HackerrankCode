using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        
        // Variables assignation
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apples = Array.ConvertAll(apple_temp,Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] oranges = Array.ConvertAll(orange_temp,Int32.Parse);
        
        // Count the oranges that got into the house
        int orangesCount = 0;
        int orangesStartPoint = s-b; // in the zone
        int orangesEndPoint = t-b; // in the zone
        
        foreach(int orange in oranges)
        {    
            if(orange >= orangesStartPoint && orange <= orangesEndPoint)
            {
                orangesCount++;
            }
        }
        
        int applesCount = 0;
        int applesStartPoint = s-a; // in the zone
        int applesEndPoint = t-a; // in the zone
        
        foreach(int apple in apples)
        {    
            if(apple >= applesStartPoint && apple <= applesEndPoint)
            {
                applesCount++;
            }
        }
        
        
        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }
}
