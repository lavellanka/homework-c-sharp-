using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ФИ: Свиргстина Александра
  
Задача 3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */
namespace math
{
    class Program
    {
        static double Result(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние между точками равно - {0:F}", Result(20, 5, 45, 10));
            Console.ReadKey();

            //Способ без метода:

             Console.WriteLine("Введите координаты точки a1:");
             double a1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите координаты точки a2:");
             double a2 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите координаты точки b1:");
             double b1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите координаты точки b2:");
             double b2 = Convert.ToDouble(Console.ReadLine());
             double r = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
             Console.WriteLine("Расстояние между точками равно - {0:F}", r);
             Console.ReadKey();
             


        }
    }
}
