using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp, long.Parse);
        
        List<long> output = new List<long>();
        output.Add(arr[0] + arr[1] + arr[2] + arr[3]); // 4
        output.Add(arr[1] + arr[2] + arr[3] + arr[4]); // 0
        output.Add(arr[2] + arr[3] + arr[4] + arr[0]); // 1
        output.Add(arr[3] + arr[4] + arr[0] + arr[1]); // 2
        output.Add(arr[4] + arr[0] + arr[1] + arr[2]); // 3

        var outputArray = output.ToArray();
        Array.Sort<long>(outputArray);
        Console.Write(outputArray[0].ToString());
        Array.Reverse(outputArray);
        Console.Write(" " + outputArray[0].ToString());
        Console.ReadKey();
    }
}