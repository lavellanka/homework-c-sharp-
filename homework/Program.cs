using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ: Свиргстина Александра

namespace homework
{
    class Program
    {
        static void Clearing()//для очистки консоли после завершения задачи;
        {
            Console.Write("Для перехода к следующей задаче нажмите Enter");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
            Count();
            Length();
            NumSumOdd();
            Check();
            Console.ReadKey();
        }

        static int MinNum()//задача 1. Написать метод,возвращающий минимальное из трех чисел;
        {
            Console.WriteLine("Задача 1. Написать метод, возвращающий минимальное из трех чисел.\nВведите три целых числа.");
            Console.Write("Первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Третье число:");
            int c = int.Parse(Console.ReadLine());
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static int Count()//задача 2.Написать метод подсчета кол-ва цифр числа(вар.1);
        {
            Clearing();
            Console.WriteLine("Задача 2.Написать метод подсчета цифр числа.\n(Вариант 1, с циклом while).");
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            while (number > 0)
            {
                i++;
                number /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            return 0;
        }
        
        static void Length()//задача 2. вариант 2;
        {
            Clearing();
            Console.WriteLine("Задача 2.Написать метод подсчета цифр числа.\n(Вариант 2, со свойством String.Length).");
            Console.Write("Введите число: ");
            string s = Console.ReadLine();
            int length = s.Length;
            Console.WriteLine("Количество цифр введенного числа : {0}", length);
        }

        static void NumSumOdd()//задача 3.С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.
        {
            Clearing();
            Console.WriteLine("Задача 3.С клавиатуры вводятся числа, пока не будет введен 0.\nПодсчитать сумму всех нечетных положительных чисел.\nДля окончания ввода чисел, нажмите введите 0 и Enter.");

            int sum1 = 0;
            int input = 0;
            do
            {
                Console.Write("Введите число: ");
                input = int.Parse(Console.ReadLine());
                if (input > 0 && input % 2 == 1)
                    sum1 += input;

            } while (input != 0);
            Console.WriteLine("Cумма равна " + sum1);
        }
        
        static void Check()//задача 4.
                           /*Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
                        * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
                        * Используя метод проверки логина и пароля, написать программу:
                        * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
                        * С помощью цикла do while ограничить ввод пароля тремя попытками.
                        */
        {
            Clearing();
            Console.WriteLine("Задача 4.Реализовать метод проверки логина и пароля.");
            int count = 1;
            Console.Write("Введите логин: ");
            string userLog = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine();

            do
            {
                if (UserCheck(userLog, userPassword) == false)//метод проверки ниже
                {
                    if (count > 3)
                    {
                        Console.WriteLine("Доступ заблокирован: Превышен лимит попыток!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Попытка №: {count}");
                        Console.WriteLine("Данные введены неверно.Попробуйте еще раз.");
                        Console.Write("Введите логин: ");
                        userLog = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        userPassword = Console.ReadLine();
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Всё верно!");
                    break;
                }
            } while (true);
        }
        
        static bool UserCheck(string log, string password)//Метод проверки логина и пароля:
        {
            if (log == "root" && password == "GeekBrains")
                return true;
            else return false;
        }


    }
}