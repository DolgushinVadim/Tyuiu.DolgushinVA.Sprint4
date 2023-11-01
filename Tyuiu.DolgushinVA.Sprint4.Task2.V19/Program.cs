using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint4.Task2.V19.Lib;
namespace Tyuiu.DolgushinVA.Sprint4.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными числами в диапазоне от 4 до 9. Написать программу,           *");
            Console.WriteLine("* которая считает сумму нечетных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 14;
            int[] array = new int[len];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = rnd.Next(4,10);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечётных элементов массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
