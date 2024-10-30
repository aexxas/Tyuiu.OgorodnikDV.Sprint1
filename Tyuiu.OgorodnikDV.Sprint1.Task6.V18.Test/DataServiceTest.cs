using Tyuiu.OgorodnikDV.Sprint1.Task6.V18.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(true, ds.CheckNumber("122"));
        }
    }
}