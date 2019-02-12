using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // считываем размер массива и сразу переводим в integer (можно использовать Convert.ToInt32)
            int[,] a = new int[n, n]; // создаем двумерный массив
            for (int i = 0; i < n; i++) // создаем цикл
            {
                for (int j = 0; j < i; j++) // это чтобы получился треугольник, я не знаю как объяснить нормально
                {
                    Console.Write("[*]"); // выводим звездочки            
                }
                Console.WriteLine(); // разделяем на уровни (строки)
            }
            Console.ReadKey(); // ну это чтобы он показал решение до того, как закроет программу
        }
    }
}