using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> initialPair = new List<string>();
        List<string> finalValues = new List<string>();

        // Create values to pick
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
        string[] vowels = { "a", "e", "i", "o", "u" };
        string[] full = { "b", "a", "c", "e", "d", "i","f", "o", "g", "u", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };

        // Print full values
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (n == 1)
            {
                foreach (string item in full)
                {
                    Console.WriteLine(item);
                }
            }
            // Create a password with provided params
            else
            {
                string tmp = string.Empty;

                foreach (string vowel in vowels)
                {
                    tmp = vowel;

                    // Check for lenght
                    if (n == 2)
                    {
                        foreach (string consonant in consonants)
                        {
                            tmp += consonant;
                            initialPair.Add(tmp);
                            tmp = vowel;
                        }
                    }
                    else
                    {
                        foreach (string consonant in consonants)
                        {
                            tmp += consonant;
                            initialPair.Add(tmp);
                            tmp = vowel;
                        }
                    }
                }

                // Real cases start here
                if (n > 2)
                {
                    int diff = 7 - n;
                    int positioner = 0;
                    List<string> values = new List<string>();
                    List<string> values2 = new List<string>();
                    List<string> values3 = new List<string>();
                    List<string> values4 = new List<string>();
                    List<string> values5 = new List<string>();
                    List<string> values6 = new List<string>();
                    List<string> values7 = new List<string>();
                    List<string> values8 = new List<string>();

                    for (int i = 0; i < diff; i++)
                    {
                        foreach (string consonant in consonants)
                        {
                            values.Add(consonant);
                        }
                        positioner++;
                        // 1th position                   
                        if (positioner < n)
                        {
                            foreach (string val in values)
                            {
                                foreach (string vowel in vowels)
                                {
                                    values2.Add(val + vowel);
                                }
                            }
                        }
                        positioner++;
                        // 2th position
                        if (positioner == n)
                            finalValues = values2;

                        if (positioner < n)
                        {
                            values.Clear();
                            foreach (string val in values2)
                            {
                                foreach (string consonant in consonants)
                                {
                                    values3.Add(val + consonant);
                                }
                            }
                        }
                        positioner++;
                        // 3th position
                        if (positioner == n)
                            finalValues = values3;

                        if (positioner < n)
                        {
                            values2.Clear();
                            foreach (string val in values3)
                            {
                                foreach (string vowel in vowels)
                                {
                                    values4.Add(val + vowel);
                                }
                            }
                        }
                        positioner++;
                        // 4th position
                        if (positioner == n)
                            finalValues = values4;

                        if (positioner < n)
                        {
                            values3.Clear();
                            foreach (string val in values4)
                            {
                                foreach (string consonant in consonants)
                                {
                                    values5.Add(val + consonant);
                                }
                            }
                        }
                        positioner++;
                        // 5th position
                        if (positioner == n)
                            finalValues = values5;

                        if (positioner < n)
                        {
                            values4.Clear();
                            foreach (string val in values5)
                            {
                                foreach (string vowel in vowels)
                                {
                                    values6.Add(val + vowel);
                                }
                            }
                        }
                        positioner++;
                        // 6th position
                        if (positioner == n)
                            finalValues = values6;

                        if (positioner < n)
                        {
                            values5.Clear();
                            foreach (string val in values6)
                            {
                                foreach (string consonant in consonants)
                                {
                                    values7.Add(val + consonant);
                                }
                            }
                        }
                        positioner++;
                        // 7th position
                        if (positioner == n)
                            finalValues = values7;

                        if (positioner < n)
                        {
                            values6.Clear();
                            foreach (string val in values7)
                            {
                                foreach (string vowel in vowels)
                                {
                                    values8.Add(val + vowel);
                                }
                            }
                        }
                        // 8th position
                        if (positioner == n)
                            finalValues = values8;
                        // No more positions 
                    }

                    // Output the result of the procedure
                    foreach (string value in finalValues)
                    {
                        Console.WriteLine(value);
                    }
                }
                else
                {
                    // Output the result of the procedure
                    foreach (string value in initialPair)
                    {
                        Console.WriteLine(value);
                    }
                }

            }
        }
                
        //Console.ReadKey(); // wait
    }
}
