using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Свиргстина Александра
 
Задача 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах
 */
namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько вы весите в кг?");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какой у вас рост в метрах?(1 м = 100 см, например 175 см = 1,75 м)");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = Convert.ToDouble(m / (h * h));
            Console.WriteLine("Ваш ИМТ равен - {0:F1}", i);

            if (i < 15)
            {
                Console.WriteLine("Индекс соответсвтует критическому дефициту массы тела");
            }
            else if (i == 15 || i < 16)
            {
                Console.WriteLine("Индекс соответсвтует выраженному  дефициту массы тела");
            }
            else if (i == 16 || i < 18.5)
            {
                Console.WriteLine("Индекс соответсвтует дефициту массы тела");
            }
            else if (i == 18.5 || i < 25)
            {
                Console.WriteLine("Индекс соответсвует нормальной массе тела");
            }
            else if (i == 25 || i < 30)
            {
                Console.WriteLine("Индекс соответсвтует избыточной массе тела");
            }
            else if (i == 30 || i < 35)
            {
                Console.WriteLine("Индекс соответсвтует ожирению первой степени (умеренное)");
            }
            else if (i == 35 || i < 40)
            {
                Console.WriteLine("Индекс соответсвтует ожирению второй степени (тяжелое)");
            }
            else if (i >= 40)
            {
                Console.WriteLine("Индекс соответсвтует ожирению третьей степени (очень тяжелое)");
            }

            Console.ReadKey();
        }
    }
}
