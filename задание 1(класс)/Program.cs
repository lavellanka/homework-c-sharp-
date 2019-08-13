using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ:Свиргстина Александра

/*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/


namespace задание_1_класс_
{
    class Complex
    {
        private double im;
        double re;

        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex
            {
                im = x2.im + im,
                re = x2.re + re
            };
            return x3;
        }
        public Complex Substraction(Complex x2)
        {
            Complex x3 = new Complex
            {
                im = im - x2.im,
                re = re - x2.re
            };
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex
            {
                im = re * x2.im + im * x2.re,
                re = re * x2.re - im * x2.im
            };
            return x3;
        }
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }

        public string ToString()
        {
            return $"{re} + {im}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(3, 3);
            Complex complex2 = new Complex(1, 1);

            complex2.Im = 3;
            Complex result1 = complex1.Plus(complex2);
            Complex result2 = complex1.Substraction(complex2);
            Complex result3 = complex1.Multi(complex2);

            Console.WriteLine(result1.ToString());
            Console.WriteLine(result2.ToString());
            Console.WriteLine(result3.ToString());
            Console.ReadKey();
        }
    }
}
