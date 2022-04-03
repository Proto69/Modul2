using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i]);
            }
        }
    }
}
