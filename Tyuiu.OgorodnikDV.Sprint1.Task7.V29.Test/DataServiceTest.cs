using Tyuiu.OgorodnikDV.Sprint1.Task7.V29.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double wait = 1.41;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}