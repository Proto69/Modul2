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
            List<int> numbers = 
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> row = numbers.Take(numbers.Count / 4).Reverse().ToList();
            row = row.Concat(numbers.TakeLast(numbers.Count / 4).Reverse().ToList()).ToList();

            numbers.RemoveRange(0, numbers.Count / 4);

            for (int i = 0; i < row.Count; i++)
            {
                row[i] += numbers[i];
            }

            Console.WriteLine(string.Join(" ", row));
        }
    }
}
