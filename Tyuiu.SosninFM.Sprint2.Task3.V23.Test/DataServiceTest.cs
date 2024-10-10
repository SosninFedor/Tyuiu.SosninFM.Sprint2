
using Tyuiu.SosninFM.Sprint2.Task3.V23.Lib;

namespace Tyuiu.SosninFM.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds1 = new DataService();
            double x = 2;
            double res = ds1.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds2 = new DataService();
            double x = 0;
            double res = ds2.Calculate(x);
            double wait = -5.333;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds3 = new DataService();
            double x = 1;
            double res = ds3.Calculate(x);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds4 = new DataService();
            double x = -30;
            double res = ds4.Calculate(x);
            double wait = -20.001;
            Assert.AreEqual(wait, res);
        }
    }
}