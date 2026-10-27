using Tyuiu.GaitovaAA.Sprint3.Task0.V10.Lib;

namespace Tyuiu.GaitovaAA.Sprint3.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.033264872534185766;

            Assert.AreEqual(wait, res);
        }
    }
}
