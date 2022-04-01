using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int system = commands[0];
            int number = commands[1];
            int result = 0;
            List<int> arr = new List<int>();
            arr.Add(result);
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == system)
                    {
                        arr[j] = 0;
                        try
                        {
                            arr[j + 1]++;
                        }
                        catch
                        {
                            arr.Add(1);
                        }
                    }
                }
                arr[0]++;
            }
            arr.Reverse();
            Console.WriteLine(string.Join("", arr));
        }
    }
}
