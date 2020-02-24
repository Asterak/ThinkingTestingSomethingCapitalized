using System;
using System.Collections.Generic;
using System.Linq;

namespace ThinkingTestingSomethingCapitalized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Testit("aa")); //aA expected
            Console.WriteLine(Testit("a a"));
            Console.WriteLine(Testit("hello world"));   //hellO worlD  expected
        }

        public static string Testit(string s)
        {
            var tmpArr = s.Split(" ");
            var resList = new List<string>();

            foreach (var item in tmpArr)
            {
                if (item.Length > 1) resList.Add(item.Substring(0, item.Length - 1).ToLower() + item.Substring(item.Length - 1).ToUpper()); // item.Substring(1).ToUpper()
                else resList.Add(item.ToUpper());
            }
            
            return string.Join(" ",resList);
        }
    }
}
