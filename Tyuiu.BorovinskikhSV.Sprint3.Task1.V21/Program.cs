using Tyuiu.BorovinskikhSV.Sprint3.Task1.V21.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 1                                                                   *");
            Console.WriteLine("* p = П (k=1..12) ( (0.5 + k/5) / (cos(x) + 0.5) )^3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 1;
            int startValue = 1;
            int stopValue = 12;
            double p = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine("* p = " + $"{p:F2}".PadRight(66) + " *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
