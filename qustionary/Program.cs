using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ФИ: Свиргстина Александра
 
 Задача 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.
 */

namespace qustionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую! Прошу, ответьте на несколько простых вопросов:\nКак вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Теперь, пожалуйста, введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вы весите в кг?");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какой у вас рост в метрах?(1 м = 100 см, например 175 см = 1,75 м)");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вас зовут: " + name + " " + surname + "\nВам " + age + "лет\nВаш вес и рост: " + m + "кг, " + h + "м.");
            Console.WriteLine($"Вас зовут: {name} {surname}\nВам {age} лет\nВаш вес и рост:{m}кг, {h}м.");
            Console.ReadKey();
        }
    }
}