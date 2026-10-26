using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
