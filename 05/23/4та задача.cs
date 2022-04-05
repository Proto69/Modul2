using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(Console.ReadLine().Split(' ').ToArray(), Console.ReadLine());
        }

        static void Start(string[] bannedWords, string text)
        {
            foreach (string word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
