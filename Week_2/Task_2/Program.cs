using System;       // общее
using System.Collections.Generic;       // для листа
using System.IO;        // для работы с файлами

namespace Task_2
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
            FileStream fs = new FileStream(@"C:\Texts\input_t2.txt", FileMode.Open, FileAccess.Read);       //открываем файл, указывая до него путь
            StreamReader sr = new StreamReader(fs);     // считываем

            String s = sr.ReadToEnd();
            int[] arr = Array.ConvertAll<string, int>(s.Split(), int.Parse);        // создаем массив, сразу конвертим и разделяем по пробелу

            List<int> primeArr = new List<int>(arr.Length);         // создаем листик в который будем вписывать наши простые числа
            foreach (int el in arr)
            {
                if (Prime(el))
                {
                    primeArr.Add(el);
                }
            }

            using (StreamWriter sw = new StreamWriter(@"C:\Texts\output.txt"))       // оутпутим в другой текстовый документ
            {
                foreach (int el in primeArr)
                {
                    sw.Write(el + " ");
                }

                sw.Close();
                sr.Close();    
            }
        }
    }
}

