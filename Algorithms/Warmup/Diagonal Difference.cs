using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int sumA = 0;
        int sumB = 0;
        
        int indexA = 0;
        for(int i=0; i<n; i++){
            sumA = sumA + a[indexA][i];
            indexA++;
        }
        
        int indexB = n-1;
        for(int i=0; i<n; i++){
            sumB = sumB +a[indexB][i];
            indexB--;
        }
        
        Console.WriteLine(Math.Abs(sumA - sumB));
    }
}
