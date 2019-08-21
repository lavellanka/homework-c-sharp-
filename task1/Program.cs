using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ФИ: Свиргстина Александра

/*Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
функцией a*sin(x).*/

namespace task1
{
    class Program
    {
        public static double F(double a, double x, int func)
        {
            if (func == 1)
            {
                return a * x * x;
            }
            return a * Math.Sin(x);

        }
        public static void SaveFunc(string fileName, double a, double b, double h, int func)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(a, x, func));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            SaveFunc("data.bin", -100, 100, 0.5, 1);
            Console.WriteLine(Load("data.bin"));

            SaveFunc("data.bin", -100, 100, 0.5, 2);
            Console.WriteLine(Load("data.bin"));

            Console.ReadKey();
        }
    }
}
