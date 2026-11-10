using Tyuiu.TelminovMS.Sprint4.Task2.V2.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[] array = {1,2,3,4,5,6};
            int res = ds.Calculate(array);
            int wait = 15;

            Assert.AreEqual(wait, res);

        }
    }
}
