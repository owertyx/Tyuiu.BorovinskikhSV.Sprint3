using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            int k = startValue;
            do
            {
                s += Math.Pow(1 / (Math.Sin(k) + 2 * Math.Pow(value, 2)), k);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(s, 2);
        }
    }
}
