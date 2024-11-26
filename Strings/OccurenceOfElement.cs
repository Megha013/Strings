//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    public class OccurenceOfElement
//    {
//        static void Main(string[] args)
//        {
//            string input = "programming";
//            bool[] visited = new bool[input.Length];
//            for (int i = 0; i < input.Length; i++)
//            {
//                if (!visited[i])
//                {
//                    char c = input[i];
//                    int count = 1;
//                    for (int j = i + 1; j < input.Length; j++)
//                    {
//                        if (input[j] == c)
//                        {
//                            count++;
//                            visited[j] = true;
//                        }
//                    }
//                    Console.WriteLine($"Character '{c}' occurs {count} times");
//                }
//            }
//        }
//    }
//}
