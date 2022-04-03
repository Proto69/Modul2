using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestForPalindrom(Console.ReadLine());
        }

        static void TestForPalindrom(string word)
        {
            string a = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                a += word[i];
            }
            if (a == word) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
