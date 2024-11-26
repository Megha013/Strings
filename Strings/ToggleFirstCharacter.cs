//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class ToggleFirstCharacter
//    {
//        static void Main(string[] args)
//        {
//            string input = "hello world from c#";
//            string result = "";

//            bool newWord = true;
//            for (int i = 0; i < input.Length; i++)
//            {
//                char c = input[i];
//                if (c == ' ')
//                {
//                    result += c;
//                    newWord = true;
//                }
//                else if (newWord && c >= 'a' && c <= 'z')
//                {
//                    result += (char)(c - 32); // Convert to uppercase
//                    newWord = false;
//                }
//                else
//                {
//                    result += c;
//                    newWord = false;
//                }
//            }
//        }
//    }
//}
