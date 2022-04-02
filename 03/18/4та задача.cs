using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = new int[3];
            commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            numbers.RemoveRange(0, commands[1]);
            bool isHere = false;
            for (int i = 0; i < commands[0] - commands[1]; i++)
            {
                if (numbers[i] == commands[2]) isHere = true;
            }
            if (isHere) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
