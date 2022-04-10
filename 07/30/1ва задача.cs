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
            //Не работи с 00:00 :/
            List<DateTime> numbers = 
                Console.ReadLine()
                .Split(' ')
                .Select(DateTime.Parse)
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i].ToString("hh:mm")} ");
            }
        }
    }
}
