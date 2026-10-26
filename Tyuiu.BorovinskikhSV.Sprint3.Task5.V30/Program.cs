using Tyuiu.BorovinskikhSV.Sprint3.Task5.V30.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Боровинских С. В. | Вариант 30";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Боровинских С. В. | СМАРТб-26-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение суммы двойного ряда при X = 2                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            Console.WriteLine("Старт шага 2 = " + startValue2);
            Console.WriteLine("Конец шага 2 = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("Сумма двойного ряда = " + res);
            Console.ReadKey();
        }
    }
}
