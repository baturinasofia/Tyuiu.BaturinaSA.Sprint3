﻿using Tyuiu.BaturinaSA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task4.V4;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3| Выполнила: Бтурина С. А. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Алгоритмическая структура цикла foreach                           *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=x/(cos(x)+sin(x))                                             *");
        Console.WriteLine("* При х = 0 прервать цикл.Полученные значения суммировать.                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Стартовое значение Х = " + startValue);
        Console.WriteLine("Конечное значение Х = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Значение функции = " + ds.Calculate(startValue, stopValue));

        Console.ReadKey();
    }
}
