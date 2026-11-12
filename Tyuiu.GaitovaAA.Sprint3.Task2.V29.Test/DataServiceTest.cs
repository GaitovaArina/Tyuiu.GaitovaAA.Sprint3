using Tyuiu.GaitovaAA.Sprint3.Task2.V29.Lib;

namespace Tyuiu.GaitovaAA.Sprint3.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startvalue = 1;
            int stopvalue = 18;

            double res = ds.GetSumSeries(value,startvalue, stopvalue);
            double wait = -0.186;

            Assert.AreEqual(wait, res);
        }
    }
}
