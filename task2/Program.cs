using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//ФИ:Свиргстина Александра

/*2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.*/

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message txt = new Message("Джон Рональд Руэл Толкин (3.01.1892–2.09.1973) – писатель, поэт, филолог," +
                "профессор Оксфордского университета, родоначальник современной фэнтези. В 1937 году был написан «Хоббит»," +
                "а в середине 1950-х годов увидели свет три книги «Властелина колец», " +
                "повествующие о Средиземье – мире, населенном представителями волшебных" +
                " рас со сложной культурой, историей и мифологией.");

            txt.SearchWordsLenghtLessN(5);
            Console.WriteLine();

            txt.ClearLastSymbol_S('я');
            Console.WriteLine();

            txt.SearchLongestWords();

            Console.ReadKey();
        }
    }

    public class Message
    {
        string msg;

        public Message(string message)
        {
            msg = message;
        }

        // Выводим слова длиной не больше n букв, где n - максимальное количество букв
        public void SearchWordsLenghtLessN(int n)
        {
            string onlyLetters = Clear(); // чистим текст
            string[] words = onlyLetters.Split(' '); // разбиваем на массив из слов

            Console.WriteLine("Список слов длиной не больше {0} симв.:", n);
            foreach (string item in words)
            {
                if (item.Length <= n)
                {
                    Console.WriteLine(item);
                }
            }
        }


        //Метод сортировки слов по убыванию длины 
        public void SearchLongestWords()
        {
            Clearing();
            string onlyLetters = Clear(); // чистим текст
            string[] words = onlyLetters.Split(' '); // разбиваем на массив из слов

            // находим максимальную длину слова
            int maxLetters = 0;
            foreach (string item in words)
            {
                if (item.Length > maxLetters)
                {
                    maxLetters = item.Length;
                }
            }

            Dictionary<int, List<string>> words_rating = new Dictionary<int, List<string>>(maxLetters); // создаем словарь с количеством букв и списком слов

            // заполняем словарь пустыми списками
            for (int i = 0; i < (maxLetters + 1); i++)
            {
                words_rating[i] = new List<string>();
            }

            // заполняем словарь словами
            foreach (string item in words)
            {
                words_rating[item.Length].Add(item);
            }

            // выводим словарь по убыванию количества букв
            for (int i = maxLetters; i > 0; i--)
            {
                if (words_rating[i].Count != 0)
                {
                    Console.WriteLine("Количество букв: {0:D2} Список слов: ", i);

                    foreach (var item in words_rating[i])
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }


        //метод, показывающий все слова без определенной буквы на конце.
        public void ClearLastSymbol_S(char s)
        {
            Clearing();
            string onlyLetters = Clear();
            string[] words = onlyLetters.Split(' '); // разбиваем на массив из слов
            List<string> words_list = new List<string>(words);

            foreach (string item in words)
            {
                if (item.Length > 0 && item[item.Length - 1] == s)
                {
                    words_list.Remove(item);
                }
            }

            Console.WriteLine("Сообщение без слов с символом \"{0}\" на конце:\n{1}", s, String.Join(" ", words_list));
        }

        // Метод для удаления из текста лишних символов (пунктуация, цифры и пр.)
        public string Clear()
        {
            string msg2 = msg;
            string pattern = @"[^a-zA-Zа-яА-я\s]"; // любой символ за исключением a-z, A-Z, а-я, А-Я и пробела
            string target = ""; // менять будем на пустоту
            Regex regex = new Regex(pattern);
            string onlyLetters = regex.Replace(msg2, target); // остаются только буквы и пробелы

            // убираем двойные пробелы
            string pattern2 = @"[\s+]"; // любой ряд пробелов
            string target2 = " "; // менять на пробел
            Regex regex2 = new Regex(pattern2);
            onlyLetters = regex2.Replace(onlyLetters, target2); // остаются только буквы и одинарные пробелы

            //Console.WriteLine("Текст после чистки:{0}", onlyLetters);
            return onlyLetters;
        }

        static void Clearing()//для очистки консоли после завершения задачи;
        {
            Console.Write("Для перехода к следующему методу нажмите Enter");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
