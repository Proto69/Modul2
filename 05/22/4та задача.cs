using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').Where(x => x != "" && x != " ").ToArray();
            if (numbers.Length > 10) Console.WriteLine("Invalid input! Too much words!");
            else
            {
                double sum = 0;
                foreach (string number in numbers)
                {
                   sum += GetSumOfNumber(number);
                }
                //Ппц в единият пример изкарва .125, ама не го закръглява на .13 ами на .12
                Console.WriteLine($"{sum:F2}");
            }  
        }
        static double GetSumOfNumber(string number)
        {
            double realNumber = int.Parse(number.Substring(1, number.Length - 2));
            realNumber = FirstLetter(number, realNumber);
            realNumber = LastLetter(number, realNumber);
            return realNumber;
        }

        /*static void NumberToList(List<string> num, string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                num.Add(number[i].ToString());
            }
        }*/

        static double FirstLetter(string number, double realNumber)
        {
            string a = number[0].ToString();
            
            if (a == a.ToUpper())
            {
                double n = (int)char.Parse(a.ToLower()) - 96;
                realNumber /= n;
            }
            else
            {
                double n = (int)char.Parse(a) - 96;
                realNumber *= n;
            }
            return realNumber;
        }

        static double LastLetter(string number, double realNumber)
        {
            string a = number[number.Length - 1].ToString();
            if (a == a.ToUpper())
            {
                double n = (int)char.Parse(a.ToLower()) - 96;
                realNumber -= n;
            }
            else
            {
                double n = (int)char.Parse(a) - 96;
                realNumber += n;
            }
            return realNumber;
        }
    }
}
