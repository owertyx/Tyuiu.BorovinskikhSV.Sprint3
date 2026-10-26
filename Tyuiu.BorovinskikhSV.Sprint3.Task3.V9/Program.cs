using Tyuiu.BorovinskikhSV.Sprint3.Task3.V9.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Строка: 56hy vfe4r4 vf45b                                               *");
            Console.WriteLine("* Заменить цифры на букву: w                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string str = "56hy vfe4r4 vf45b";
            char item = 'w';
            string res = ds.ReplaceNumOnChar(str, item);

            Console.WriteLine("* " + res.PadRight(71) + " *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
