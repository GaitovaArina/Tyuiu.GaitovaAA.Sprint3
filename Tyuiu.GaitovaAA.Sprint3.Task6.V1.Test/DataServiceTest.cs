using Tyuiu.GaitovaAA.Sprint3.Task6.V1.Lib;

namespace Tyuiu.GaitovaAA.Sprint3.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 151;

            Assert.AreEqual(wait, res);
        }
    }
}
