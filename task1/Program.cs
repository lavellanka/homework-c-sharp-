using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ:Свиргстина Александра

/*1. Создать программу, которая будет проверять корректность ввода логина.
 * Корректным логином будет строка от 2 до 10 символов,
 * содержащая только буквы латинского алфавита или цифры,
 * при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.*/

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Результат проверки на корректность без регулярных выражений: {0}", LogIn_NoReg(login));
            Console.ReadKey();
        }

        //// Метод проверки корректности логина
        static bool LogIn_NoReg(string login)
        {
            // если длина от 2 до 10 и первый символ не цифра, то проверяем каждый символ на букву или цифру
            if (login.Length >= 2 && login.Length <= 10 && char.GetNumericValue(login[0]) == -1)
            {
                foreach (char item in login)
                {
                    if (char.IsLetterOrDigit(item) == false)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
