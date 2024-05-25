using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = GetArrayFromConsole();
            int t = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i+1; j < nums.Length; j++) {
                    if (nums[i] > nums[j])
                    {
                        t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                    }
            }
        }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}
