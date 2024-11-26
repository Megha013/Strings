//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class Anagram
//    {
//        public static void FindAnagram(string s1, string s2)
//        {
              //6.Check whether String is Anagram.
//            s1 = s1.ToLower();
//            s2 = s2.ToLower();
//            if (s1.Length == s2.Length)
//            {
//                char[] ch1 = s1.ToCharArray();
//                char[] ch2 = s2.ToCharArray();

//                Array.Sort(ch1);
//                Array.Sort(ch2);
//                Console.WriteLine(ch1);
//                Console.WriteLine(ch2);
//                //Boolean result = Array.Equals(ch1, ch2);
//                //Console.WriteLine(Array.Equals(ch1, ch2));
//                if (ch1.Equals(ch2))
//                {

//                    Console.WriteLine("Anagram");
//                }
//                else
//                {
//                    Console.WriteLine("Not Anagram");
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            string s1 = "Care";
//            string s2 = "Race";
//            FindAnagram(s1, s2);
//        }
//    }
//}
