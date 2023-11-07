using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint4.Task6.V9.Lib;
namespace Tyuiu.DolgushinVA.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных  [ Красный, Оранжевый, Желтый, Зеленый,     *");
            Console.WriteLine("* Синий, Индиго, Фиолетовый]. Написать программу, которая, используя класс*");
            Console.WriteLine("* Array считает количество элементов, длина которых меньше 7.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var color = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= color.Length - 1; i++)
            {
                Console.WriteLine(color[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int count = ds.Calculate(color);

            Console.WriteLine("Количество элементов, длина которых меньше 7: " + count);
            Console.ReadKey();
        }
    }
}
