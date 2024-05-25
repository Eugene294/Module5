using System;

namespace final_task5_6_1
{
    internal class Program
    {
        static void Main()
        {
            (string name, string surname, int age, string[] pets, string[] colors) Data = GetData();

            Showdata(Data);

        }

        static (string name, string surname, int age, string[] pets, string[] colors) GetData()
        {

            (string name, string surname, int age, string[] pets, string[] colors) Data;

            Console.Write("Ваше имя: ");
            Data.name = Console.ReadLine();
            Console.Write("Ваша фамилия:  ");
            Data.surname = Console.ReadLine();


            do
            {
                Console.Write("Ваш возраст: ");
                Data.age = CheckNum(Console.ReadLine());
            } while (Data.age==0);

            bool pet;
            Console.Write("Напишите \"да\", если у вас есть животные:  ");
            pet = Console.ReadLine() == "да";


            if (pet)
            {
                Console.WriteLine("Сколько у вас животных?");
                int num_pets = CheckNum(Console.ReadLine());
                Data.pets = GetPets(num_pets);
            }
            else
            {
                Data.pets = null;
            }

            Console.WriteLine("Сколько у вас любимых цветов?");
            int num_colors = CheckNum(Console.ReadLine());
            Data.colors = GetColors(num_colors);


            return Data;
        }

        static int CheckNum(string num)
        {
            if (int.TryParse(num, out int Num))
            {
                if (0 < Num)
                {
                    return Num;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        static string [] GetPets(int num)
        {
            string [] pets = new string[num];

            for (int i = 0; i < pets.Length; i++)
            {
                Console.Write($"Введите имя {i+1}-го питомца: ");
                pets[i] = Console.ReadLine();
            }
            return pets;
        }

        static string[] GetColors(int num) { 
        
            string[] colors = new string[num];

            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write($"Введите {i+1}-й цвет: ");
                colors[i] = Console.ReadLine();
            }
            return colors;

        }

        static void Showdata((string name, string surname, int age, string[] pets, string[] colors) Data)
        {
            Console.WriteLine($"Имя: {Data.name}");
            Console.WriteLine($"Фамилия: {Data.surname}");
            Console.WriteLine($"Возраст: {Data.age}");
            if (!(Data.pets is null))
            {
                Console.WriteLine("Животные:");
                foreach (string item in Data.pets) Console.WriteLine(item);
            }
            Console.WriteLine("Цвета:");
            foreach (string item in Data.colors) Console.WriteLine(item);
        }

    }
}
