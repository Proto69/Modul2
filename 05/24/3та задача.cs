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
            Start(Console.ReadLine().Split('@').ToArray());
        }

        static void Start(string[] text)
        {
            if (text[0].Length >= text[1].Length) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");
        }
    }
}
