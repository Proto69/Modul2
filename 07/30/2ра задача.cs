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
                .Where(x => x % 2 == 0)
                .ToList();

            double average = numbers.Average();
            numbers = 
                 numbers
                .Select(x =>
               {
                   if (x > average) x++;
                   else x--;
                   return x;
               })
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
