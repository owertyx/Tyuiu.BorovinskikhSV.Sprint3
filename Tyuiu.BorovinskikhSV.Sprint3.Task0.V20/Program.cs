using Tyuiu.BorovinskikhSV.Sprint3.Task0.V20.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 1                                                                   *");
            Console.WriteLine("* p = П (k=1..14) ( cos(x) + (k/8)^3 )                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 1;
            int startValue = 1;
            int stopValue = 14;
            double p = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine("* p = " + $"{p:F2}".PadRight(66) + " *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}


