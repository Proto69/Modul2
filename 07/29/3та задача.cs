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
            List<string> words = 
                Console.ReadLine()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ')
                .Where(x => x != "" && x.Length < 5)
                .Select(x => x.ToLower())
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
