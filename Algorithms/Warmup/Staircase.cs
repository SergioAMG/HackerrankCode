using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> staircase = new List<string>();
        
        string row = string.Empty;

        for (int i=0; i<n; i++)
        {
            int diff = (i - n) * -1;
            int unit = n - diff;

            for (int c = 0; c < unit; c++)
            {
                row += " "; 
            }
            for (int b=0; b<diff; b++)
            {
                row += "#";
            }
            staircase.Add(row);
            row = null;
        }
        staircase.Reverse();
        foreach (string item in staircase)
        {
            Console.WriteLine(item);
        }
        
    }
}
