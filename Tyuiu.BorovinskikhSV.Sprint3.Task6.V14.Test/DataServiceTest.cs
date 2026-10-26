using Tyuiu.BorovinskikhSV.Sprint3.Task6.V14.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // Количество делителей больше 5 на отрезке [7, 16] равно 13
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}
