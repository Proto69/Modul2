using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            //според мен така се решава задачата
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            //ако гледаме примера ще видим, че най-големият елемент липсва
            //за да го махнем просто пишем
            int[] result = new int[arr.Length - 1];
            Array.Copy(arr, result, arr.Length - 1);
            //и след това принтим вместо arr, result
            Console.WriteLine(string.Join(" ", result));
        }
    }
}