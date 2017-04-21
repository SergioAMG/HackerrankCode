using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        List<string> output = new List<string>();

        // Iterate through all cases 
        for (int i = 0; i < cases; i++)
        {
            // Read data
            int currentMax = int.MinValue;
            int globalMax = int.MinValue;
            int capacity = Convert.ToInt32(Console.ReadLine());
            string[] tmp = Console.ReadLine().Split(' ');
            int[] subarray = Array.ConvertAll(tmp, Int32.Parse);
            int maxNonContiguous = 0;

            // Initialize values
            currentMax = subarray[0];
            globalMax = currentMax;

            // Iterate through single cases
            for (int c = 0; c < capacity; c++)
            {
                // Calculate max contiguous
                // If is the first element of subarray don't apply max operation
                if (c != 0)
                    currentMax = Math.Max(subarray[c], currentMax + subarray[c]);

                if (currentMax > globalMax)
                {
                    globalMax = currentMax;
                }

                // Calculate max non-contiguous elements
                maxNonContiguous = Math.Max(maxNonContiguous, maxNonContiguous + subarray[c]);

            }
            // Save output
            if (maxNonContiguous == 0)
            {
                maxNonContiguous = globalMax;
            }
            output.Add(globalMax + " " + maxNonContiguous);
        }

        // Print output      
        foreach (string item in output)
        {
            Console.WriteLine(item);
        }

    }
}