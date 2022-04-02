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

            bool value = true;

            while (value)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    value = false;
                    if(numbers[i] == numbers[i + 1])
                    {
                        numbers[i + 1] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i);
                        value = true;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', numbers)) ;
        }
    }
}
