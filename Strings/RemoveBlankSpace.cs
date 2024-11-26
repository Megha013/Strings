//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class RemoveBlankSpace
//    {
//        static void Main(string[] args)
//        {
//            //6.  Write a C# program to remove all extra blank spaces from a given string
//            string input = "   This   is    a    test        string.  ";
//            string result = "";
//            bool wasSpace = true;

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] != ' ')
//                {
//                    result += input[i];
//                    wasSpace = false;
//                }
//                else if (!wasSpace)
//                {
//                    result += ' ';
//                    wasSpace = true;
//                }
//            }
//            Console.WriteLine(result.Trim());
//        }
//    }
//}
