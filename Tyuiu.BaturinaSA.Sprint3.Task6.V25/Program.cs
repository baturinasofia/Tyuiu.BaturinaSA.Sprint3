﻿using Tyuiu.BaturinaSA.Sprint3.Task6.V25.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task6.V25;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.WriteLine("Спринт #3 | Выполнила: Батурина С. А. | ИСТНб-25-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Батурина Софья Алексеевна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [16, 24] сумму всех делителей меньше 10               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");


        int startValue = 16;
        int stopValue = 24;

        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Сумма делителей меньше 10 = {ds.GetSumTheDivisors(startValue, stopValue)}");


        Console.ReadKey();

    }
}
