using System;

namespace Task_2
{
    class Student // создаем класс
    {
        public string name;
        public string id;
        public int year; // public делает наши переменные доступными везде, в любой функии

        public Student(string name, string id) //создаем конструктор
        {
            this.name = name; 
            this.id = id; // this хранит адрес
        }

        public void PlusOne()
        {
            year++; // прибавляем единицу вау
            Console.WriteLine(year);
        }

        public void Print()
        {
            Console.WriteLine(name + " " + id + " "); //выводим на экран имя и id
        }
    }

    class Program
    {

        static void HopeItWorks()
        {
            Student st = new Student("Alyona", "18BD110806")
            {
                year = int.Parse(Console.ReadLine()) // тут мы считываеем и сразу переводим в integer
            };

            st.Print();
            st.PlusOne(); // вызываем другие функции
        }

        static void Main(string[] args)
        {
            HopeItWorks(); // мы вызываем только 1 функцию потому что внутри нее мы уже вызвали остальные
            Console.ReadKey();
        }
    }
}
