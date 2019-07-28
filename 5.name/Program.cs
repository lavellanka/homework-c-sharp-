using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ФИ: Свиргстина Александра
 
 задача 5 а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */

namespace name
{
    class Program
    {
        static void Print(int x, int y, string name, string town)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(name);
            Console.WriteLine(town);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 25);

            Print(17, 11, "Меня зовут Александра Свиргстина.", "Я живу в городе Талдом, что находится в Московской области.");

            /*string n = "Александра";
            string s = "Свиргстина";
            string t = "Талдом";
            Console.SetCursorPosition(20, 9);
            Console.WriteLine($"Меня зовут {n} {s}.");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine ($"Я живу в городе {t}, что находится в Московской области");*/

            Console.ReadKey();
        }

    }
}