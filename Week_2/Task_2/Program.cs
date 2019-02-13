using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        public static void ReadF()
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            String[] arr = s.Split();
            int sum = 0;
            foreach (String a in arr)
            {
                sum += int.Parse(a);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(sum);
            sw.Close();
        }

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
            ReadF();
            Prime();
            Console.WriteLine("Hello World!");
        }
    }
}
