using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        public bool Palin(object s1)
        {
            StreamReader sr = new StreamReader("input.txt");        //открываем файл 
            String s1 = sr.ReadToEnd();     // присваиваем строке всё содержимое файла
            String[] arr = s1.Split();      // разделяем по пробелу
            int i = 0;
            int j = s1.Length - 1;

            while (i < j)
            {
                if (s1[i] != s1[j])         // проверяем строку на палиндромность через реверс
                    return false;

                i++;
                j--;
            }

            return true;

        }


        static void Main(string[] args)
        {
            for (int i = 0; i < s1.Length; i++)     // создаем цикл, который бежит от 1 до значения, равному размеру строки
            {
                if (Palin(s1[i]))        // проверяем строку на палиндромность с помощью вызова функции
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }

            Console.ReadKey();          // ну это чтобы он показал решение до того, как закроет программу
        }
    }
}
