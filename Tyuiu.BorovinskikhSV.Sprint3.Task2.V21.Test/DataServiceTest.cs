using Tyuiu.BorovinskikhSV.Sprint3.Task2.V21.Lib;
namespace TestProject1Tyuiu.BorovinskikhSV.Sprint3.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1.5, 1, 10);
            double wait = 0.24;
            Assert.AreEqual(wait, res);
        }
    }
}
