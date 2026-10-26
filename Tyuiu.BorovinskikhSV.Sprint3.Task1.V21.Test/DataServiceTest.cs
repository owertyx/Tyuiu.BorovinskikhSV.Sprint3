using Tyuiu.BorovinskikhSV.Sprint3.Task1.V21.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 12);
            double wait = 16947810.88;
            Assert.AreEqual(wait, res);
        }
    }
}
