using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++) ShowColor(anketa.name, anketa.age);
        }

        static string ShowColor(string name, int age)
        {
            Console.WriteLine($"{name}, {age} лет.\nНапишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;


        }
    }
}
