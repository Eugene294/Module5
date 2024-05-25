﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ShowArray(GetArrayFromConsole(3), true);
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] array)
        {
            int t;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            return array;
        }

        static void ShowArray(int[] array, bool sort = false)
        {
            if (sort) SortArray(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
