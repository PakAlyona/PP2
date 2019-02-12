using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static void ReadF()
        {
            StreamReader sr = new StreamReader("input.txt");        //открываем файл 
            String s = sr.ReadToEnd();     // присваиваем строке всё содержимое файла
            String[] arr = s.Split();      // разделяем по пробелу
        }

        public static bool Palin()
        {
            
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])         // проверяем строку на палиндромность через реверс
                    return false;

                i++;
                j--;
            }

            return true;

            //sr.Close();

        }


        static void Main(string[] args)
        {
            ReadF();

            for (int i = 0; i < s.Length; i++)     // создаем цикл, который бежит от 1 до значения, равному размеру строки
            {
                if (Palin(s[i]))        // проверяем строку на палиндромность с помощью вызова функции
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }

            Console.ReadKey();          // ну это чтобы он показал решение до того, как закроет программу
        }
    }
}
