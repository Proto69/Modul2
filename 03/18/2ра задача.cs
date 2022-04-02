using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] {' ', ',', ':', '[', ']', ';', '.', '!', '(', ')', '"', '\'', '/', '\\' })
                .Where(x => x!="" && x!=" ")
                .ToList();

            var upper = new List<string>();
            var lower = new List<string>();
            var others = new List<string>();
            foreach (string word in words)
            {
                bool mixed = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!Char.IsLetter(word[i]))
                    {
                        mixed = true;
                    }
                }
                if (word == word.ToLower() && !mixed)
                {
                    lower.Add(word);
                }
                else if (word == word.ToUpper() && !mixed)
                {
                    upper.Add(word);
                }
                else others.Add(word);
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", others)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");

        }
    }
}
