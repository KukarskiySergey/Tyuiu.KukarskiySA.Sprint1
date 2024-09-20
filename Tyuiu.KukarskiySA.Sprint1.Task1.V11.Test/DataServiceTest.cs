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
            double x = 2;
            double y = 3;
            var result = dataService.Calculate(x, y);

            Assert.AreEqual(18, result);
        }
    }
}