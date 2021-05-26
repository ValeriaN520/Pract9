using System;
using System.Collections;
using System.Linq;

namespace Практическая_работа9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int[,] a = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(a[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 2");
            int[,] ms = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    ms[i, j] = rand.Next(10);
                    Console.Write($"{ms[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3");
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                int sumStr = 0;
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    sumStr += ms[i, j];
                }
                Console.WriteLine($"Сумма элементов строки {i}: " + sumStr + " ");
            }
            Console.WriteLine("Задание 4");
            string r = "";
            string o = "";
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    if ((ms[i, j] % 2 != 0) && (ms[i, j] % 3 != 0))
                    {
                        r = r + ms[i, j];
                    }
                }
            }
            r = new string(r.Distinct().ToArray());
            Console.WriteLine($"Простые числа = {r}");
        }
    }
}
