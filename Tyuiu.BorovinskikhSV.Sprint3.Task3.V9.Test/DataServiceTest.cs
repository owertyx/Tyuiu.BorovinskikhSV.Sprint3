using Tyuiu.BorovinskikhSV.Sprint3.Task3.V9.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string res = ds.ReplaceNumOnChar("56hy vfe4r4 vf45b", 'w');
            string wait = "wwhy vfewrw vfwwb";
            Assert.AreEqual(wait, res);
        }
    }
}
