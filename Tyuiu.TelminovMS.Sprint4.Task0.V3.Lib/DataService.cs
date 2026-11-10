using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TelminovMS.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int pr = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    pr = pr * array[i];
                }
            }
            return pr;
        }
    }
}
