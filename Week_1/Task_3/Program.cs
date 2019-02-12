using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine()); // считываем размер массива и сразу переводим в integer (можно использовать Convert.ToInt32)
            int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse); //создаем и считываем массив из string в integer, 
            // отделяем числа друг от друга по пробелу
            for (int i = 0; i < a.Length; i++) // создаем цикл, который бежит от 1 до значения, равному размеру массива
            {
                Console.Write(a[i] + " " + a[i] + " "); // выводим элементы дважды
            }
            Console.ReadKey(); // ну это чтобы он показал решение до того, как закроет программу
        }
    }
}