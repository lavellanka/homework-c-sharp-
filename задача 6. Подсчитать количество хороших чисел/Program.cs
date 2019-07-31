using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ: Свиргстина Александра.
/*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
 * Хорошим называется число, которое делится на сумму своих цифр.
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

namespace задача_6.Подсчитать_количество_хороших_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            GoodNumbers();
            Console.WriteLine("Время затраченное на выполнение: " + (DateTime.Now - a));
            Console.ReadKey();
        }
        static void GoodNumbers()
        {
            int count = 0;//количество хороших чисел
            int number = 1;

            do
            {
                if (CheckedGoodNumbers(number))
                    count++;
                number++;
                //Console.WriteLine($"Количество хороших чисел равно {count}");
            } while (number >= 1 && number <= 1000000000);
            Console.WriteLine($"Колличество хороших чисел равно {count}");
        }
        static bool CheckedGoodNumbers(int n)
        {
            int sum = 0;
            int num1 = n;
            while (num1 > 0)
            {
                sum += num1 % 10;
                num1 /= 10;
            }
            if (num1 == n % sum)
                return true;
            else return false;
        }
    }
}