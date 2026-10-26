using Tyuiu.BorovinskikhSV.Sprint3.Task2.V21.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 1,5                                                                 *");
            Console.WriteLine("* S = Σ (k=1..10) ( 1 / (sin(k) + 2x^2) )^k                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double x = 1.5;
            int startValue = 1;
            int stopValue = 10;
            double s = ds.GetSumSeries(x, startValue, stopValue);

            Console.WriteLine("* S = " + $"{s:F2}".PadRight(66) + " *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}