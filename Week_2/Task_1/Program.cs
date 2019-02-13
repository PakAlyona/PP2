using System;
using System.IO;


namespace Task_1
{
    class Program
    {

        public static bool Palin(string s)
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

        }


        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Texts\input_t1.txt", FileMode.Open, FileAccess.Read);       //открываем файл, указывая до него путь
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadLine();     // переводим данные с файла в строку

            if (Palin(str))     //чекаем на палиндромность
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
            Console.ReadKey();



        }
    }
}
