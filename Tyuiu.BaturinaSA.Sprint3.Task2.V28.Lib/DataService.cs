using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BaturinaSA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            do
            {
                MultiplySeries = MultiplySeries + Math.Pow(2, startValue) / (startValue + 1) * (Math.Cos(1.8));
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(MultiplySeries, 3);

        }
    }
}
