//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class HighestFrequency
//    {
//        static void Main(string[] args)
//        {
//            //8.Write a C# program to find the highest frequency character in a string.
//            string input = "programming";
//            int[] frequency = new int[256]; // Array to count the frequency of each character
//            char maxChar = '\0'; // To store the character with the highest frequency
//            int maxFrequency = 0; // To store the highest frequency

//            for (int i = 0; i < input.Length; i++)
//            {
//                frequency[input[i]]++;
//            }
//            for (int i = 0; i < frequency.Length; i++)
//            {
//                if (frequency[i] > maxFrequency)
//                {
//                    maxFrequency = frequency[i];
//                    maxChar = (char)i;
//                }
//            }
//            Console.WriteLine($"The highest frequency character is '{maxChar}' with {maxFrequency} occurrences.");
//        }
//    }
//}

