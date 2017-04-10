using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int denominator = Convert.ToInt32(Console.ReadLine());
        string[] arrTmp = Console.ReadLine().Split(' ');
        int[] data = Array.ConvertAll(arrTmp,Int32.Parse);
        float positive = 0;
        float negative = 0;
        float zero = 0;
        // Count values
        foreach(int item in data)
        {
            if (item > 0)
            {
                positive++;
            } else if (item < 0)
            {
                negative++;   
            } else 
            {
                zero++;
            }
        }
        float rPositive =  positive / denominator;
        float rNegative =  negative / denominator;
        float rZero =  zero / denominator;
            
        Console.WriteLine(rPositive.ToString());
        Console.WriteLine(rNegative.ToString());
        Console.WriteLine(rZero.ToString());
    }
}
