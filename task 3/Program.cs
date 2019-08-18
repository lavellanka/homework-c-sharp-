using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ФИ: Свиргстина Александра

/*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.*/

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Является ли одна строка перестановкой другой? " + Comparing("badc", "abcd"));
                Console.WriteLine("Является ли одна строка перестановкой другой? " + Comparing("badc", "abcde"));
                Console.ReadKey();
        }

         static bool Comparing(string word1, string word2)
            {
                if (word1.Length == word2.Length)
                {
                    char[] array1 = word1.ToCharArray();
                    char[] array2 = word2.ToCharArray();
                    Array.Sort(array1);
                    Array.Sort(array2);
                    return Enumerable.SequenceEqual(array1, array2);
                }
                return false;
         }
    }
}
