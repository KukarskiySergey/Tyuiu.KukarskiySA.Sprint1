using Tyuiu.KukarskiySA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            double x = 123.456;
            double result = dataService.Calculate(x);

            Assert.AreEqual(4, result);
        }
    }
}