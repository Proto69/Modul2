using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSumOfBigNumbers(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        //Последният пример от тази задача е грешен
        //Може да се сметне с калкулатор
        static void GetSumOfBigNumbers(string number1, int number2)
        {
            List<int> num1 = new List<int>();

            NumberToList(num1, number1);

                Result(num1, number2);
        }

        static void NumberToList(List<int> num, string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                num.Add(int.Parse(number[i].ToString()));
            }
        }

        static void Result(List<int> num1, int num2)
        {
            num1[0] = num1[0] * num2;
            for (int i = 1; i < num1.Count; i++)
            {
                num1[i] = num1[i] * num2;
                if (num1[i - 1] >= 10)
                {
                    try
                    {
                        num1[i] += (num1[i - 1]/10)%10;
                    }
                    catch
                    {
                        num1.Add(1);
                    }
                    num1[i - 1] -= ((num1[i - 1] / 10) % 10) * 10;
                }

            }
            num1.Reverse();
            Console.WriteLine(string.Join("", num1));
        }
    }
}
