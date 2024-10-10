
using Tyuiu.SosninFM.Sprint2.Task2.V9.Lib;

namespace Tyuiu.SosninFM.Sprint2.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}