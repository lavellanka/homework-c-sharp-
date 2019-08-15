using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
массив определенного размера и заполняющий массив числами от начального значения с
заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод
Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый
массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу
библиотеки
е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)*/

namespace task3
{
    public class Array
    {
        int[] a;
        Random rnd = new Random();

        // Создание массива и заполнение его одним значением el
        public Array(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        // Создание массива и заполнение его случайными числами от min до max
        public Array(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        //подсчет количества позитивных чисел
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    

        //реализовать конструктор, создающий
        //массив определенного размера и заполняющий массив числами от начального значения с
        //заданным шагом.

        public void Step(int count, int start, int step)
        {
            a = new int[count];
            for (int i = 0; i < count; i++)
            {
                a[i] = start + (step * i);
            }
        }

        //Создать свойство Sum, которое возвращает сумму элементов массива,
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }


        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
        // массив, остается без изменений)
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }
        }
        //метод Multi, умножающий каждый элемент массива на определённое число
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
        }
        //свойство MaxCount, возвращающее количество максимальных элементов.
        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        count = 1;
                    }
                    else if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        class Program
        {
            static void Main()
            {
                Array a = new Array((int)10, (int)0, (int)100);
                Console.WriteLine(a.ToString());
                Console.WriteLine("Максимальное значение массива: " + a.Max);
                Console.WriteLine("Минимальное значение массива: " + a.Min);
                Console.WriteLine("Количество положительных чисел: " + a.CountPositiv);


                Console.WriteLine("Сумма всех элементов массива равна: " + a.Sum);

                a.Multi(3);
                Console.WriteLine("Умножаем на 3 каждый элемент массива: ");
                Console.WriteLine(a.ToString());

                a.Inverse();
                Console.WriteLine("Инверсия: ");
                Console.WriteLine(a.ToString());

                Console.WriteLine("Количество максимальных элементов в массиве: " + a.MaxCount);

                Console.ReadKey();


            }
        }

    }
}
