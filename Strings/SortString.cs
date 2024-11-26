//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class SortString
//    {
//        static void Main(string[] args)
//        {
//            //2. Write a program to sort string arrays on the basis of length and if length is same
//            //then lexicographically
//            string[] words = { "apple", "bat", "banana", "cat", "an" };

//            for (int i = 0; i < words.Length - 1; i++)
//            {
//                for (int j = 0; j < words.Length - 1 - i; j++)
//                {
//                    if (words[j].Length > words[j + 1].Length ||
//                        (words[j].Length == words[j + 1].Length && Compare(words[j], words[j + 1]) > 0))
//                    {
//                        // Swap
//                        string temp = words[j];
//                        words[j] = words[j + 1];
//                        words[j + 1] = temp;
//                    }
//                }
//            }
//        }
//    }
//}
