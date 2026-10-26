
using Tyuiu.BorovinskikhSV.Sprint3.Task0.V20.Lib;

namespace Tyuiu.BorovinskikhSV.Sprint3.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 14);
            double wait = 287.18;
            Assert.AreEqual(wait, res,);
        }
    }
}
