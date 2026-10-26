using Tyuiu.BorovinskikhSV.Sprint3.Task7.V8.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = new double[11];
            wait[0] = -8.86;
            wait[1] = -7.19;
            wait[2] = -6.14;
            wait[3] = -4.76;
            wait[4] = -2.33;
            wait[5] = 1.00;
            wait[6] = 4.38;
            wait[7] = 0.00; // при x = 2 деление на ноль -> 0
            wait[8] = 6.13;
            wait[9] = 7.07;
            wait[10] = 8.61;

            Assert.AreEqual(wait.Length, res.Length);
            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i], 0.01, $"Ошибка на индексе {i} (при x = {startValue + i})");
            }
        }
    }
}
