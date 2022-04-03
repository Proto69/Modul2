using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfChars(Console.ReadLine().Split(' ').ToArray());

        }
        static void SumOfChars(string[] words)
        {
            string word1 = words[0];
            string word2 = words[1];
            int result = 0;
            bool value = false;

            for (int i = 0; i < word1.Length; i++)
            {
                try
                {
                    int sum = (int)word1[i] * (int)word2[i];
                    result += sum;
                }
                catch
                {
                    value = true;
                    result += (int)word1[i];
                }
            }

            if (!value)
            {
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
