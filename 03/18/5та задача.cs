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

            bool isRunning = true;

            while (isRunning)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                switch (command[0].ToLower())
                {
                    case "print":
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                        isRunning = false;
                        break;
                    case "add":
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "addmany":
                        command.RemoveAt(0);
                        int index = int.Parse(command[0]);
                        command.RemoveAt(0);
                        command.Reverse();
                        for (int i = 0; i < command.Count; i++)
                        {
                            numbers.Insert(index, int.Parse(command[i]));
                        }
                        break;
                    case "contains":
                        bool isHere = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == int.Parse(command[1]))
                            {
                                Console.WriteLine(i);
                                isHere = true;
                                break;
                            }
                        }
                        if (!isHere) Console.WriteLine("-1");
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        Shift(numbers, int.Parse(command[1]));
                        break;
                    case "sumpairs":
                        SumOfPairs(numbers);
                        break;
                }
            }
        }
        static void SumOfPairs(List<int> numbers)
        {
            for (int i  = 0; i < numbers.Count - 1; i++)
            {
                numbers[i + 1] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i);
            }
        }

        static void Shift(List<int> numbers, int postitionsToShift)
        {
            if (numbers.Count >= 3)
            {
                numbers.Reverse();
                for (int i = 0; i < postitionsToShift; i++)
                {
                    int last = numbers[numbers.Count - 1];
                    int n = numbers[0];
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        int a = numbers[j];
                        numbers[j] = n;
                        n = a;
                    }
                    numbers[0] = last;
                }
                numbers.Reverse();
            }
            else numbers.Reverse();
        }
    }
}
