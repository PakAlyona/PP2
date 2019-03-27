using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void Spisok (int floor)
        {
            for (int i = 0; i < floor; i++)
            {
                Console.Write("   ");      // чтоб красиво всё разделялось
            }
        }

        public static void Direc(DirectoryInfo dir, int floor) 
        {
            foreach (FileInfo f in dir.GetFiles())      // не уверена че она делает, но кажется вызывает предыдущие дериктории
            {
                Spisok(floor);     // разделяем, властвуем, унижаем
                Console.WriteLine(f.Name);
            } 

            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Spisok(floor);     // разделяем, властвуем, унижаем
                Console.WriteLine(d.Name);
                Direc(d, floor + 1);        // рекурсируем
            }

        }

        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo("C:/Users/User/desktop/Study/University");      // выбираем папку

            Direc(directory, 0);        // призываем функцию

            Console.ReadKey();
        }
    }
}