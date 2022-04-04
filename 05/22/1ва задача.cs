using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //Нямам си напредстава дали работи напълно
        //Най-объркващата задача 
        static void Main(string[] args)
        {
            TestForMagic(Console.ReadLine().Split(' ').ToArray()) ;
        }

        static void TestForMagic(string[] word)
        {
            bool value = true;

            char[] word1 = word[0].ToCharArray();
            char[] word2 = word[1].ToCharArray();



            if (word1.Length < word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    char question = word1[i];
                    char rightAnswer = word2[i];
                    for (int j = i; j < word2.Length; j++)
                    {
                        try
                        {
                            if (word2[j] == rightAnswer && word1[j] == question)
                            {
                                word2[j] = ' ';
                            }
                        }
                        catch
                        {
                            if (word2[j] == rightAnswer) word2[j] = ' ';
                        }
                    }
                }
                word2 = word2.Where(x => x != ' ').ToArray();
                if (word2.Length >= 1) value = false;
            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    char question = word1[i];
                    char rightAnswer = word2[i];
                    for (int j = i; j < word2.Length; j++)
                    {
                        if (word1[j] == question && word2[j] != rightAnswer)
                        {
                            value = false;
                            break;
                        }
                    }
                }
            }
            if (value) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
