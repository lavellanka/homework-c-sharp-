using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace УгадайЧисло
{
    public partial class Form1 : Form
    {
        private Random rand = new Random(); // переменная для получения случайного числа
        private int number; // число которое нужно угадать (случайное)
        private int countTry = 0; // счётчик попыток пользователя угадать

        public Form1() // конструктор формы
        {
            InitializeComponent(); // вызываем функцию инициализации компонентов окна
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close(); // закрываем игру
        }

        private void butPlayRestart_Click(object sender, EventArgs e)
        {
            // если надпись на кнопке "Игры или Рестарта" написано "Играть"
            // то есть пользователь только включил игру и нажал кнопку Играть
            if (butPlayRestart.Text == "Играть") 
            {
                number = rand.Next(100); // снова загадываем случайное число от 0 до 100
                // переписываем надпись на кнопке, что бы можно было
                butPlayRestart.Text = "Переиграть"; // занаво начать игру той же кнопкой
                // включаем для использования 
                labelCountTry.Enabled = true; // лейбочку подсчёта попыток
                tBoxMyNumber.Enabled = true; // и поле ввода числа
                labelMoreLess.Text = ""; // чистим лейбочку индикации больше число или меньше
            }
            else // сюда мы попадаем когда хотим переиграть и нажимаем на кнопку "Переиграть"
            {
                number = rand.Next(100); // снова загадываем случайное число от 0 до 100
                countTry = 0; // обнуляем счётчик подсчёта попыток игрока угадать
                labelCountTry.Text = "Сделано попыток: 0"; // обнуляем вывод попыток
                tBoxMyNumber.Text = ""; // чистим поле ввода числа
                butTry.Enabled = false; // выключаем кнопку "Проверить"
                labelMoreLess.Text = ""; // чистим лейбачку индикации больше чило или меньше
            }
        }

        private void tBoxMyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // проверяем нажатую клавишу
            // если она не есть число или управляющая тогда указываем что 
            // это событие обработано и нажатый символ не выводиться
            // (по опыту управляющий символ - Backspace, другие управляющие клавиши я не нашёл)
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                // включаем кнопку "Проверить"
                butTry.Enabled = true;
            }
        }

        private void butTry_Click(object sender, EventArgs e)
        {
            butTry.Enabled = false; // выключаем кнопку "Проверить"
            // переводим введенную строку в число
            int inputNumber = Convert.ToInt32(tBoxMyNumber.Text); 
            // проверяем введённое значение в textBox что бы оно не превышало границы (100)
            if (inputNumber > 100)
            {
                MessageBox.Show("Вы ввели больше значение чем можно. Введите другое",
                    "Угадай число", MessageBoxButtons.OK);
                tBoxMyNumber.Text = ""; // чистим textBox
            }
            else
            {
                labelCountTry.Text = "Сделано попыток: " + (++countTry).ToString(); // считаем попытки
                if (inputNumber > number)  // проверяем больше ли введёное чило от загаданого
                    labelMoreLess.Text = "Ваше число больше"; // и выводим результат сравнивания
                else if (inputNumber < number) // проверяем меньше ли введёное число
                    labelMoreLess.Text = "Ваше число меньше"; // и выодим результат
                else // сюда попадаем когда мы угадали число
                {
                    MessageBox.Show("          Поздравляем!   \n" +
                                                 "Вы угадали число за " + countTry.ToString() + " попыток"
                                                 , "Угадай число",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tBoxMyNumber.Text = ""; // чистим поле ввода чисел
                    // чистим лейбл индикации больше введённое число или меньше
                    labelMoreLess.Text = ""; 
                    countTry = 0; // обнуляем счётчик попыток игрока
                    labelCountTry.Text = "Сделано попыток: 0"; // обнуляем вывод попыток
                    labelCountTry.Enabled = false; // делаем не доступным лейбл попыток
                    tBoxMyNumber.Enabled = false; // делаем не доступным поле ввода числа
                    butPlayRestart.Text = "Играть"; // меняем натпись на кнопке Играть
                    
                }
            }
        }
    }
}
