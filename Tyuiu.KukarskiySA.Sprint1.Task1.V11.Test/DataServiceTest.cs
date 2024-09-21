using Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            double x = 12;
            double y = 4;
            double result = dataService.Calculate(x, y);

            Assert.AreEqual(2.5, result);
        }
    }
}