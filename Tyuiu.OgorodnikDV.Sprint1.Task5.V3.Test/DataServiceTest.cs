using Tyuiu.OgorodnikDV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 130985;
            DataService ds = new DataService();
            int res = ds.Calculate(k);

            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}