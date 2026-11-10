using Tyuiu.TelminovMS.Sprint4.Task6.V7.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string[] st = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };

            var res = ds.Calculate(st);
            var wait = 3;

            Assert.AreEqual(wait, res);

        }
    }
}
