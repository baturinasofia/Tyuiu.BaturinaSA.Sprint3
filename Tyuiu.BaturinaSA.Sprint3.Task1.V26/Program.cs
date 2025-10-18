using Tyuiu.BaturinaSA.Sprint3.Task1.V26.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task1.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Батурина С. А. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму        *");
        Console.WriteLine("* ряда по формуле, при n=5                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 5;
        int startValue = 1;
        int stopValue = 8;

        Console.WriteLine(" Переменная n = " + value);
        Console.WriteLine(" Старт шага = " + startValue);
        Console.WriteLine(" Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadLine();
    }
}
