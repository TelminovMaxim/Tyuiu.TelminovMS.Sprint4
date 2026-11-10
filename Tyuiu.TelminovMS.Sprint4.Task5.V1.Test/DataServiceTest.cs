using Tyuiu.TelminovMS.Sprint4.Task5.V1.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 6, -9, 5, 3, 3 }, { 5, 7, -8, 6, 4 }, { 1, 2, 4, 1, 5 }, { 1, 7, 2, 5, 7 }, { 4, 2, 6, 5, 6 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 1, -9, 1, 1, 1 }, { 1, 1, -8, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
