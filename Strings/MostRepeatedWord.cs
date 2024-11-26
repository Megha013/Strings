////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Strings
////{
////    public class MostRepeatedWord
////    {
////        static void Main(string[] args)
////        {
////            //3.WAP to find the most repeated word in a string
////            string input = "apple banana apple orange banana apple";
////            string[] words = SplitWords(input);
////            int[] count = new int[words.Length];
////            int maxCount = 0;
////            string mostRepeated = "";

////            // Count occurrences of each word
////            for (int i = 0; i < words.Length; i++)
////            {
////                for (int j = 0; j < words.Length; j++)
////                {
////                    if (words[i] == words[j])
////                    {
////                        count[i]++;
////                    }
////                }
////                if (count[i] > maxCount)
////                {
////                    maxCount = count[i];
////                    mostRepeated = words[i];
////                }
////            }
////        }
//static string[] SplitWords(string input)
//{
//    string[] words = new string[input.Length];
//    string currentWord = "";
//    int index = 0;

//    for (int i = 0; i < input.Length; i++)
//    {
//        if (input[i] != ' ')
//        {
//            currentWord += input[i];
//        }
//        else
//        {
//            words[index++] = currentWord;
//            currentWord = "";
//        }
//    }
//    words[index++] = currentWord;

//    // Trim the array
//    string[] trimmedWords = new string[index];
//    for (int i = 0; i < index; i++)
//    {
//        trimmedWords[i] = words[i];
//    }
//    return trimmedWords;
////}
////    }
////}
