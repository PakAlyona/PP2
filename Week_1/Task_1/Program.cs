using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static bool Prime(int a) // создаем логическую функцию, которая определяет простоту числа
        {
            if (a == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // считываем размер массива и сразу переводим в integer (можно использовать Convert.ToInt32)
            int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse); //создаем и считываем массив из string в integer, 
                                                                                               // отделяем числа друг от друга по пробелу
            int pr = 0; // вводим счетчик
            List<int> arrPrime = new List<int>(); // создаем лист

            for (int i = 0; i < a.Length; i++) // создаем цикл, который бежит от 1 до значения, равному размеру массива
            {
                if (Prime(a[i]))
                {
                    pr++;
                    arrPrime.Add(a[i]); // добавляяем простые числа в лист
                }
            }
                Console.WriteLine(pr); // выводим кол-во простых чисел
                foreach (int elem in arrPrime) // выводим простые числа
                {
                    Console.Write(elem + " ");
                }

                Console.ReadKey(); // ну это чтобы он показал решение до того, как закроет программу
            
        }
    }
}
