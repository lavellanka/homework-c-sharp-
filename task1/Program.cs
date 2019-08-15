using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ: Свиргстина Александра

/*Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать
программу, позволяющую найти и вывести количество пар элементов массива, в которых только
одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление массива длинной 20 элементов с минимальным и максимальным значениями 
            MyArray myArray = new MyArray(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.ReadKey();
        }
    }
    public class MyArray
    {
        //Приватное поле-массив класса Array 
        private int[] am;


        //Конструктор массива с заполением случайными числами 
        public MyArray(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);
        }

        //Метод подсчета пар чисел, которые делятся на 3
        public int Divisibility3()
        {
            int count = 0;
            for (int i = 0; i < am.Length - 1; i++)
            {
                if (am[i] % 3 == 0 || am[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", am[i], am[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }

        //Метод вывода массива на консоль
        override public string ToString()
        {
            string stringarray = "";
            foreach (int x in am)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }
}
