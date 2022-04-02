using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //вторият даден пример е грешен!
            List<int> numbers =Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool isRunning = true;
            while (isRunning)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0].ToLower())
                {
                    case "odd":
                        numbers = numbers.Where(x => x % 2 != 0).ToList();
                        isRunning = false;
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "even":
                        numbers = numbers.Where(x => x % 2 == 0).ToList();
                        isRunning = false;
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "delete":
                        numbers = numbers.Where(x => x != int.Parse(command[1])).ToList();
                        break;
                    case "insert":
                        numbers[int.Parse(command[2])] = int.Parse(command[1]);
                        break;
                }
            }
        }
    }
}
