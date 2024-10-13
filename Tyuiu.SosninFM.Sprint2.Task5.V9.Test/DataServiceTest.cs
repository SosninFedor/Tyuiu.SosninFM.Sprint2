
using Tyuiu.SosninFM.Sprint2.Task5.V9.Lib;

namespace Tyuiu.SosninFM.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 30;
            string wait = "31 Мая";
            var res = ds.FindDateOfNextDay(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}