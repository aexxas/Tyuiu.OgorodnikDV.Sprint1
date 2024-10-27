using Tyuiu.OgorodnikDV.Sprint1.Task2.V13.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.OgorodnikDV.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            Assert.AreEqual(3.2186, x);
        }
    }
}