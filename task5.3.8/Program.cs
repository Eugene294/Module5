using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._3._8
{
    internal class Program
    {
        static void Main()
        {
            int a = 6;
            GetArrayFromConsole(ref a);
        }

        static void GetArrayFromConsole(ref int num)
        {
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
