using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ: Свиргстина Александра Александровна
/*5. а) Написать программу, которая запрашивает массу и рост человека,
 * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

namespace BMI
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
                Console.WriteLine("У Вас критический  дефицит массы тела");

            else if (i == 15 || i < 16)
                Console.WriteLine("У Вас выраженный  дефицит массы тела");

            else if (i == 16 || i < 18.5)
                Console.WriteLine("У Вас дефицит массы тела");

            else if (i == 18.5 || i < 25)
                Console.WriteLine("У Вас нормальная масса тела");

            else if (i == 25 || i < 30)
                Console.WriteLine("У Вас избыточная масса тела");

            else if (i == 30 || i < 35)
                Console.WriteLine("У Вас ожирение I степени (умеренное)");

            else if (i == 35 || i < 40)
                Console.WriteLine("У Вас ожирениие II степени (тяжелое)");

            else if (i >= 40)
                Console.WriteLine("У Вас ожирение II степени (очень тяжелое)");

            Console.ReadKey();
        }
    }
}
