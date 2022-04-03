using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            int system = int.Parse(commands[0]);
            string number = commands[1];

            List<int> numbers = new List<int>();
            

            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(int.Parse(number[i].ToString()));
            }

            double result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                double num = numbers[i] * Math.Pow(system, numbers.Count-i-1);
                result += num;
            }

            Console.WriteLine(result);
        }
    }
}
