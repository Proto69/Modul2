using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            int[] arr2 = arr.Select(x => x - 97).ToArray();
            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine($"{arr[i]} -> {arr2[i]}");
            }
        }
    }
}
