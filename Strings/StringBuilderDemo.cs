//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class StringBuilderDemo
//    {
//        static void Main(string[] args)
//        {
//            char[] ch = { 'a', 'e', 'i', 'o', 'u' };
//            StringBuilder sb = new StringBuilder("Hello");  // mutable
//            Console.WriteLine(sb);
//            Console.WriteLine(sb.GetHashCode());
//            Console.WriteLine("Capacity : "+sb.Capacity);
//            // to modify data/string in the class we have append
//            sb.Append(" Good Morning");
//            sb.Replace("Hello", "Hi");
//            sb.Remove(2, 4);
//            sb.Clear();
//            sb.CopyTo(3, ch, 0, 5);
//            string str1 = string.Join("", ch);
//            sb.Append(str1);
//            Console.WriteLine(sb);
//            Console.WriteLine(sb.GetHashCode());
//            Console.WriteLine("Capacity : " + sb.Capacity);
//            Console.WriteLine("Length : "+sb.Length);
//        }
//    }
//}
