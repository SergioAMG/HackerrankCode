using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ProcessGrade(grade));
        }
    }

    static int ProcessGrade(int grade)
    {
        if(grade < 38) return grade; 

        if(grade % 5 < 3) return grade;

        return  (grade + 4) / 5 * 5;
    }
}