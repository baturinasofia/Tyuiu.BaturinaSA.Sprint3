using Tyuiu.BaturinaSA.Sprint3.Task2.V28.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = -15.642;

            Assert.AreEqual(res, wait);
        }
    }
}
