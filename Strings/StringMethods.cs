//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{ 
//    public class StringMethods
//    {
//        static void Main(string[] args)
//        {
//            string str1 = "Hello to all";
//            string str2 = "good evening";
//            string str3 = "Amol,Kishor,Suraj,Chetan";

//            // Concat - values from multiple strings
//            string str4 = string.Concat(str1, str2);
//            Console.WriteLine(str3);

//            // Split - separate values 
//            string[] names = str3.Split(',');
//            foreach (var item in names)
//            {
//                Console.WriteLine(item);
//            }

//            // ToCharArray - convert string to char[]
//            char[] ch = str2.ToCharArray();
//            foreach(var item in ch)
//            {
//                Console.WriteLine(item);
//            }

//            // ToUpper
//            string str5 = str1.ToUpper();
//            Console.WriteLine(str5);

//            // ToLower
//            string str6 = str1.ToLower();
//            Console.WriteLine(str5);

//            //IndexOf - will return the index  first occurance of a character
//            int index = str1.IndexOf('I', 4);
//            Console.WriteLine(index);

//            //LastIndexOf - will return the index  last occurrence of that character
//            int last = str1.LastIndexOf('l');
//            Console.WriteLine(last);

//            // Trim - will remove the spaces which is before & after the string
//            Console.WriteLine(str1.Trim());

//            // TrimStart - remove spaces which is before the string
//            Console.WriteLine(str1.TrimStart());

//            // TrimEnd - remove spaces which is afte the string
//            Console.WriteLine(str1.TrimEnd());
//        }
//    }
//}
