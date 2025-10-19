using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BaturinaSA.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int max = 0, count = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                    if (count > max) max = count;
                }
                else count = 0;
            }
            return max;
        }
    }
}
