﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._3._3
{
    internal class Program
    {
        static void Main()
        {
            int age;
            age = int.Parse(Console.ReadLine());
            ChangeAge(ref age);
            Console.WriteLine(age);
        }

        static void ChangeAge(ref int age)
        {
            age++;
        }
    }
}
