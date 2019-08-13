using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ:Свиргстина Александра

/*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/

namespace num1
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public Complex Plus(Complex x) //Метод сложения комплексных чисел
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Subtraction(Complex x) //(дз 1а) Метод вычитания комплексных чисел
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex Multi(Complex x) //метод произведения комплексных чисел
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
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

            Complex result1 = complex1.Plus(complex2);
            Complex result2 = complex1.Subtraction(complex2);
            Complex result3 = complex1.Multi(complex2);

            Console.WriteLine(result1.ToString());
            Console.WriteLine(result2.ToString());
            Console.WriteLine(result3.ToString());

            Console.ReadKey();
        }
    }
}
