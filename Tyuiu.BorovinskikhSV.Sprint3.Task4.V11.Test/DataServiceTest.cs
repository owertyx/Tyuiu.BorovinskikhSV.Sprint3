using Tyuiu.BorovinskikhSV.Sprint3.Task4.V11.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            double wait = 0.84;
            Assert.AreEqual(wait, res);
        }
    }
}
