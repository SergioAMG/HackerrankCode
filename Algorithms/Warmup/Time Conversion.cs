using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        // Declare variables
        string time = Console.ReadLine();
        string[] timeStrings = new string[4];
        timeStrings[0] = time.Substring(0, 2);
        timeStrings[1] = time.Substring(3, 2);
        timeStrings[2] = time.Substring(6, 2);
        timeStrings[3] = time.Substring(8, 2);
        
        // Check if time is noon or not
        if (timeStrings[3] == "PM")
        {
            // Do not replace 12 for 24
            if (timeStrings[0] != "12")
            {
                Console.Write((int.Parse(timeStrings[0]) + 12).ToString() + ":" + timeStrings[1] + ":" + timeStrings[2]);
            }
            else
            {
                Console.Write(timeStrings[0] + ":" + timeStrings[1] + ":" + timeStrings[2]);
            }
        }
        else
        {
            // Replace 12 for 00
            if (timeStrings[0] == "12")
            {
                Console.Write("00" + ":" + timeStrings[1] + ":" + timeStrings[2]);
            }
            else
            {
                Console.Write(timeStrings[0] + ":" + timeStrings[1] + ":" + timeStrings[2]);
            }
            
        }    
    }
}
