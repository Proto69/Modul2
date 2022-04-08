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
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();
            Start(words);
        }
        static void Start(List<string> words)
        {
            var storage = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
                if (storage.ContainsKey(words[i]))
                {
                    storage[words[i]] ++;
                }
                else
                {
                    storage.Add(words[i], 1);
                }
            }
            List<string> result = new List<string>();
            foreach (var pair in storage)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
