using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaitovaAA.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1.0;
           
            for (int i = startValue; i <= stopValue; i++)
            {
                multiplySeries *= Math.Pow(300.0 / (i + Math.Pow(value, 2)), i);
            }
            return Math.Pow(multiplySeries, 1);
        }
    }
}
