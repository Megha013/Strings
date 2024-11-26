//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class ReplaceString
//    {
//        static void Main()
//        {
//            string input = "Hello world";
//            string oldWord = "world";
//            string newWord = "C#";

//            string result = "";
//            for (int i = 0; i < input.Length; i++)
//            {
//                bool match = true;
//                for (int j = 0; j < oldWord.Length && (i + j) < input.Length; j++)
//                {
//                    if (input[i + j] != oldWord[j])
//                    {
//                        match = false;
//                        break;
//                    }
//                }
//                if (match)
//                {
//                    result += newWord;
//                    i += oldWord.Length - 1;
//                }
//                else
//                {
//                    result += input[i];
//                }
//            }
//            Console.WriteLine(result);
//        }
//    }
//}
