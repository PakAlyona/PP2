using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Letters
{
    public class Mark
    {
        public double mark;
        public string letter;

    public Mark(double a)
        {
            mark = a;
            letter = getLetter();
        }

        public Mark()
        {
        }

        private string getLetter()
        {
            if (mark < 50) return "Loh";
            if (mark >= 50 && mark < 60) return "D";
            if (mark >= 60 && mark < 75) return "C";
            if (mark >= 75 && mark < 90) return "B";
            if (mark >= 90 && mark < 100) return "A";
            if (mark > 100 || mark < 0) return "balabol";
            else return "you're stupid";
        }

        public override string ToString()
        {
            return getLetter();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Mark> lol = new List<Mark>();

            Console.WriteLine("Write your mark");
            double save = Convert.ToDouble(Console.ReadLine());
            Mark mark = new Mark(save);
            lol.Add(mark);

            FileStream fs = new FileStream("Letter.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer serial = new XmlSerializer(typeof(List<Mark>));
            serial.Serialize(fs, lol);
            fs.Close();
            
        }
    }
}
