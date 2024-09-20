using Tyuiu.KukarskiySA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            int celsius = 0;
            int kelvin = 273;
            var result = dataService.Calculate(celsius);

            Assert.AreEqual(273, result);
        }
    }
}