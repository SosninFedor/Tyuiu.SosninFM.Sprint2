
using Tyuiu.SosninFM.Sprint2.Task4.V8.Lib;

namespace Tyuiu.SosninFM.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 175.625;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 215.973;
            Assert.AreEqual(wait, res);

        }
    }
}