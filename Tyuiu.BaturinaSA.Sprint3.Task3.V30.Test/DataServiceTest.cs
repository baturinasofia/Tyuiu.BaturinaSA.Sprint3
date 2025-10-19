using Tyuiu.BaturinaSA.Sprint3.Task3.V30.Lib;

namespace Tyuiu.BaturinaSA.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string value = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';

            int res = ds.GetMaxCharCount(value, chr);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
