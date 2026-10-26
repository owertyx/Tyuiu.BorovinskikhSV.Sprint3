using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;
            while (k <= stopValue)
            {
                p *= Math.Pow((0.5 + k / 5.0) / (Math.Cos(value) + 0.5), 3);
                k++;
            }
            return Math.Round(p, 2);
        }
    }
}
