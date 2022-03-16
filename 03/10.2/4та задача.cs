using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //декларираме всички нужни масиви

            //това е началния
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //първата половина и втората половина, които трябва да се обърнат
            int[] firstHalf = new int[nums.Length / 4];
            int[] secondHalf = new int[nums.Length / 4];
            

            //средата, която си остава в прав ред
            int[] middle = new int[nums.Length / 2];

            //двете половини в готов вид
            int[] top = new int[middle.Length];

            //крайният резултат
            int[] sum = new int[middle.Length];
            for (int i = 0; i < firstHalf.Length; i++)
            {
                firstHalf[i] = nums[i];
            }
            Array.Reverse(firstHalf);
            for (int i = 0; i < secondHalf.Length; i++)
            {
                secondHalf[i] = nums[nums.Length - i - 1];
            }
            firstHalf.CopyTo(top, 0);
            secondHalf.CopyTo(top, firstHalf.Length);
            for (int i = 0; i < middle.Length; i++)
            {
                middle[i] = nums[i + firstHalf.Length];
            }
            for (int i = 0; i < top.Length; i++)
            {
                sum[i] = top[i] + middle[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}