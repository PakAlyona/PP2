using System;
using System.IO;
using System.Xml.Serialization;

namespace Number
{
    class ComplexNumber
    {
        public double im;
        public double re;
        
    public ComplexNumber Sum(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber();
            result.re = a.re + b.re;
            result.im = a.im + b.im;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a_first;
            double a_second;
            double b_first;
            double b_second;

            Console.WriteLine("Write a1");
            a_first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write a2");
            a_second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write b1");
            b_first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write b2");
            b_second = Convert.ToDouble(Console.ReadLine());

            ComplexNumber first = new ComplexNumber();
            first.re = a_first;
            first.im = a_second;

            ComplexNumber second = new ComplexNumber();
            second.re = b_first;
            second.im = b_second;

            double[] mas = new double[2];
            mas[0] = first.Sum(first, second).re;
            mas[1] = second.Sum(first, second).im;
            Console.WriteLine("Sum of numbers: {0} + {1}i", first.Sum(first, second).re, second.Sum(first, second).im);

            XmlSerializer serial = new XmlSerializer(typeof(double[]));
            FileStream fs = new FileStream("Number.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            serial.Serialize(fs, mas);
            fs.Close();
        }
    }
}
