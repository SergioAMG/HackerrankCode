using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp, Int32.Parse);

        // your code goes here
        int highScore = 0, highBreaked = 0, lowScore = 0, lowBreaked = 0;
        for (int i=0; i<n; i++)
        {
            // Start counters
            if (i == 0)
            {
                //score = index
                highScore = score[i];
                lowScore = score[i];
            }
            // Comparations 
            else
            {
                if (score[i] > highScore)
                {
                    highScore = score[i];
                    highBreaked++;
                }
                else if (score[i] < lowScore)
                {
                    lowScore = score[i];
                    lowBreaked++;
                }
            }
        }
        Console.WriteLine(highBreaked + " " + lowBreaked);
    }
}
