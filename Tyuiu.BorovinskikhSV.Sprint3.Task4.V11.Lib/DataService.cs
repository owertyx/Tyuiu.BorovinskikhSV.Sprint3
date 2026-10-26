using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                double y = x / (Math.Sin(x) - x) + 2;
                result *= y;
            }
            return Math.Round(result, 2);
        }
    }
}
