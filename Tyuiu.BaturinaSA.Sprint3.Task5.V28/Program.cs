using Tyuiu.BaturinaSA.Sprint3.Task5.V28.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task5.V28;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Батурина. С. А. | ИСТНб-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #28                                                          *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна  | ИСТНб-25-1                   *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 12;

        Console.WriteLine("Переменная X = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряды = " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey(); ;
    }
}