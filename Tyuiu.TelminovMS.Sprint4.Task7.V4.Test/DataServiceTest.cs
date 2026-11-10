using Tyuiu.TelminovMS.Sprint4.Task7.V4.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string st = "382976421897";

            var res = ds.Calculate(3, 4, st);
            var wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}
