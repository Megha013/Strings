//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class ReverseString
//    {
//        static void Main(string[] args)
//        {
//            //1.Reverse the string word by word
//            string input = "Hello world from C#";
//            string result = "";

//            string word = "";
//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] != ' ')
//                {
//                    word += input[i];
//                }
//                else
//                {
//                    result = word + " " + result;
//                    word = "";
//                }
//            }
//            result = word + " " + result; 
//            Console.WriteLine(result.Trim());
//        }
//    }
//}
