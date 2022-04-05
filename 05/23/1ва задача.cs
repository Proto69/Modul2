using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(Console.ReadLine(), Console.ReadLine());
        }

        static void Start(string text, string shablon)
        {
            bool isRunning = true;
            while (isRunning)
            {
                int firstIndex = text.IndexOf(shablon);
                int lastIndex = text.LastIndexOf(shablon);
                int length = shablon.Length;
                if (firstIndex != lastIndex && lastIndex != -1 && firstIndex != -1)
                {
                    text = Remover(text, length, firstIndex, shablon);
                }
                else
                {
                    isRunning = false;
                    Console.WriteLine("No Shake.");
                    Console.WriteLine(text);
                }
                shablon = shablon.Remove(length / 2, 1);
            }
            
        }

        static string Remover(string text, int length, int index1, string shablon)
        {
            text = text.Remove(index1, length);
            int index2 = text.LastIndexOf(shablon);
            text = text.Remove(index2, length);
            Console.WriteLine("Shaked it.");
            return text;
        }
    }
}
