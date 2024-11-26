//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class VowelConsonantDigit
//    {
//        static void Main(string[] args)
//        {
//            //2.Calculate no of vowels, consonants  , digits and special symbol from given String
//            string str = "HA6@el4l !o12Hi@E";
//            int vowels = 0, consonants = 0, digits = 0, specials = 0;

//            for (int i = 0; i < str.Length; i++)
//            {
//                char ch = str[i];
//                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
//                {
//                    char lower = (ch >= 'A' && ch <= 'Z') ? (char)(ch + 32) : ch; // Convert to lowercase
//                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
//                        vowels++;
//                    else
//                        consonants++;
//                }
//                else if (ch >= '0' && ch <= '9')
//                    digits++;
//                else
//                    specials++;
//            }
//            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}, Digits: {digits}, Specials: {specials}");
//        }
//    }
//}
