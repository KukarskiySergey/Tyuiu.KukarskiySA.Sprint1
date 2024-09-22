using Tyuiu.KukarskiySA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            double x = 8;
            double y = 12;
            double result = dataService.Calculate(x, y);

            Assert.AreEqual(0, result);
        }
    }
}