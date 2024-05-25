using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._3._13
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 5, 3, 2, 1, 53, 213, 34 };


            SortArray(in arr, out int[] arrAsc, out int[] arrDesc);

            foreach (int i in arrAsc) Console.WriteLine(i);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (int j in arrDesc) Console.WriteLine(j);


        }

        static void SortArray(in int[] arr1, out int[] arr2, out int[] arr3)
        {
            int[] arr = new int[arr1.Length];
            arr1.CopyTo(arr, 0);
            arr2 = SortArrayAsc(arr1);
            arr3 = SortArrayDesc(arr);
        }


        static int[] SortArrayAsc(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }

            }
            return arr;
        }

        static int[] SortArrayDesc(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }
    }
}
