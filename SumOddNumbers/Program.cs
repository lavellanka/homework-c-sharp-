using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ:Свиргстина Александра

/*2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 * Требуется подсчитать сумму всех нечетных положительных чисел.
 * Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/

namespace SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int score = 0;

            while (true)
            {
                number = GetNumber();

                if (number >= 1 && number % 2 == 1)
                {
                    score += number;
                }
                if (number == 0) break;
            }

            Console.WriteLine($"Сумма нечетных, положительных чисел = {score}");
            Console.ReadKey();
        }

        // Метод ввода числа, с обработкой исключений
        static int GetNumber()
        {
            // Устанавливаем переменные и задаем значения:
            int newNumber = 0;
            bool flag = false;

            // Вечный цикл:
            while (!flag)
            {
                Console.Write("Введите число: ");

                // Обрабатываем ошибку:
                try
                {
                    newNumber = Int32.Parse(Console.ReadLine()); // Считываем данные с консоли.
                    if (newNumber >= 0 || newNumber <= 0) flag = true; // Закрываем цикл.

                }
                // Вывод ошибки:
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            // Если введен 0, выводим сообщение о выходе
            if (newNumber == 0) Console.WriteLine($"Введен {newNumber}. Выход из цикла");

            // Если ввели любое другое число, то выводим его на экран
            else Console.WriteLine($"Введенное число: {newNumber}");

            // Возвращаем число
            return newNumber;
        }
    }
}
