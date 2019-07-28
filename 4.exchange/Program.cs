using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ФИ: Свиргстина Александра
 
 задача 4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.*/

namespace exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первый способ:

            Console.WriteLine("Введите первое число(x):");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число(y):");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            //Второй способ:

            Console.WriteLine("Введите первое число(а):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число(b):");
            int b = Convert.ToInt32(Console.ReadLine());
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadKey();

        }
    }
}
