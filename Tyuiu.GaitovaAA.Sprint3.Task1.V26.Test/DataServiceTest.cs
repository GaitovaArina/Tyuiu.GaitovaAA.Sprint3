using Tyuiu.GaitovaAA.Sprint3.Task1.V26.Lib;

namespace Tyuiu.GaitovaAA.Sprint3.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int n = 5;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetSumSeries(n, startValue, stopValue);
            double wait = 1.4999999999901696;

            Assert.AreEqual(wait, res, 0.0000000001);
        }
    }
}
