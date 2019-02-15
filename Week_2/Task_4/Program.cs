using System;
using System.IO;

namespace Task4
{
    class Program
    {        
        
        public static void Main(string[] args) 
        {
                StreamWriter task4 = new StreamWriter(@"C:/Texts/path1/Task4.txt");     // создаем файл в папке1
                task4.WriteLine("Nadeus eto rabotaet");     // пишем туда текстик
                task4.Close();
                File.Copy(@"C:/Texts/path1/Task4.txt", @"C:/Texts/path2/Task4.txt");        // копируем из папки1 в папку2
                File.Delete(@"C:/Texts/path1/Task4.txt");       // удаляем в папке1

        }
    }
}