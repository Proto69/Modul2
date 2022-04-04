using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                GetSumOfBigNumbers(Console.ReadLine(), Console.ReadLine());
        }

        static void GetSumOfBigNumbers(string number1, string number2)
        {
            List<int> num1 = new List<int>();
            List<int> num2 = new List<int>();

            NumberToList(num1, number1);
            NumberToList(num2, number2);


            if (num1.Count > num2.Count)
            {
                Result(num1, num2);
            }
            else
            {
                Result(num2, num1);
            }
        }

        static void NumberToList(List<int> num, string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                num.Add(int.Parse(number[i].ToString()));
            }
        }

        static void Result(List<int> num1, List<int> num2)
        {
            for (int i = 0; i < num2.Count; i++)
            {
                num1[i] += num2[i];
                if (num1[i] >= 10)
                {
                    try
                    {
                        num1[i + 1]++;
                    }
                    catch
                    {
                        num1.Add(1);
                    }
                    num1[i] -= 10;
                }
            }
            num1.Reverse();
            Console.WriteLine(string.Join("", num1));
        }
    }
}
