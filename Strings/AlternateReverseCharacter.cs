//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class AlternateReverseCharacter
//    {
//        static void Main(string[] args)
//        {
//            //1.Show alternate characters from String from reverse.
//            //string s = "HelloDotNet";
//            //for (int i = s.Length - 1; i >= 0; i -= 2)
//            //{
//            //    Console.Write(s[i] + ", ");
//            //}
//            string str = "abcdefg";
//            string result = "";
//            for (int i = str.Length - 1; i >= 0; i--)
//            {
//                if ((str.Length - 1 - i) % 2 == 0) // Alternate characters
//                {
//                    result += str[i];
//                }
//            }
//            Console.WriteLine("Alternate characters from reverse: " + result);
//        }
//    }
//}
