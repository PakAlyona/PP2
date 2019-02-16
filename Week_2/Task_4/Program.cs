using System;
using System.IO;

namespace Task4
{
    class Program
    {        
        
        public static void Main(string[] args) 
        {
            Directory.CreateDirectory("C:/Users/User/desktop/PP2/Week_2/Task_4/path1");
            Directory.CreateDirectory("C:/Users/User/desktop/PP2/Week_2/Task_4/path2");
            StreamWriter task4 = new StreamWriter(@"C:/Users/User/desktop/PP2/Week_2/Task_4/path1/Task4.txt");     // создаем файл в папке1
                task4.WriteLine("Nadeus eto rabotaet");     // пишем туда текстик
                task4.Close();
                File.Copy(@"C:/Users/User/desktop/PP2/Week_2/Task_4/path1/Task4.txt", @"C:/Users/User/desktop/PP2/Week_2/Task_4/path2/Task4.txt");        // копируем из папки1 в папку2
                File.Delete(@"C:/Users/User/desktop/PP2/Week_2/Task_4/path1/Task4.txt");       // удаляем в папке1

        }
    }
}