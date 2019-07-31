using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ:Свиргстина Александра
//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);

namespace задача_7.Рекурсия
{
    class Program
    {
        static void Main()
        {
            RecursionMethod(1, 10);
            Console.ReadKey();
        }
        public static void RecursionMethod(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) RecursionMethod(a + 1, b);
        }
        
    }
}
