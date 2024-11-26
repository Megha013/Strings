//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class ToggleCase
//    {
//        static void Main(string[] args)
//        {
//            //9.Write a Java program to toggle case of each character of a string
//            string input = "HelloWorld123";
//            string result = "";

//            for (int i = 0; i < input.Length; i++)
//            {
//                char c = input[i];
//                if (c >= 'a' && c <= 'z')
//                {
//                    result += (char)(c - 32); // Convert lowercase to uppercase
//                }
//                else if (c >= 'A' && c <= 'Z')
//                {
//                    result += (char)(c + 32); // Convert uppercase to lowercase
//                }
//                else
//                {
//                    result += c; 
//                }
//            }
//            Console.WriteLine(result);
//        }
//    }
//}
