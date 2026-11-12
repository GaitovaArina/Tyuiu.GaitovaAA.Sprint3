using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaitovaAA.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + 1 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = 3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1));
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
