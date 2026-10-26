using Tyuiu.BorovinskikhSV.Sprint3.Task4.V11.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x принимает значения от -5 до 5, шаг 1                                  *");
            Console.WriteLine("* y = x / (sin(x) - x) + 2                                                *");
            Console.WriteLine("* При x = 0 значение пропустить, значения перемножить                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("* " + $"{res:F2}".PadRight(71) + " *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
